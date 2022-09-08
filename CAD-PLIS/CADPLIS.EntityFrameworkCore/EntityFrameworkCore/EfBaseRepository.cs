using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityFrameworkCore
{
    public class EfBaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly PlisDbcontext _plisDbcontext;
        public virtual DbSet<TEntity> DbSet => _plisDbcontext.Set<TEntity>();
        protected virtual DbContext DbContext => _plisDbcontext;
        public EfBaseRepository(PlisDbcontext plisDbcontext)
        {
            _plisDbcontext = plisDbcontext;
        }

        public async Task<TEntity> AddAsync(TEntity entity,bool autoSave=false)
        {
            DbContext.Entry<TEntity>(entity).State = EntityState.Added;
            if (autoSave)
            {
                await DbContext.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<List<TEntity>> AddRangeAsync(List<TEntity> entitys, bool autoSave = false)
        {
            foreach(var entity in entitys)
            {
                DbContext.Entry<TEntity>(entity).State = EntityState.Added;
            }
            if (autoSave)
            {
                await DbContext.SaveChangesAsync();
            }
            return entitys;
        }

        public async Task<bool> ExistAsync(Expression<Func<TEntity, bool>> anyLambda)
        {
            return await DbSet.AsNoTracking().AnyAsync(anyLambda);
        }
        public async Task<TEntity> FindModelAsync(Expression<Func<TEntity, bool>> whereLambda)
        {
            TEntity _entity = await DbSet.AsNoTracking().FirstOrDefaultAsync<TEntity>(whereLambda);
            return _entity;
        }

        public async Task<List<TEntity>> FindListAsync(Expression<Func<TEntity, bool>> whereLamdba)
        {
            var _list = await DbSet.AsNoTracking().Where<TEntity>(whereLamdba).ToListAsync();
            return _list;
        }

        public async Task<List<TEntity>> FindListAsync<S>(Expression<Func<TEntity, bool>> whereLamdba, bool isAsc, Expression<Func<TEntity, S>> orderLamdba)
        {
            var _list = DbSet.AsNoTracking().Where<TEntity>(whereLamdba);
            if (isAsc) _list = _list.OrderBy<TEntity, S>(orderLamdba);
            else _list = _list.OrderByDescending<TEntity, S>(orderLamdba);
            return await _list.ToListAsync();
        }

        public async Task<TEntity> EditAsync(TEntity entity,bool autoSave=false)
        {
            DbSet.Attach(entity);
            DbContext.Entry<TEntity>(entity).State = EntityState.Modified;
            if (autoSave)
            {
                await DbContext.SaveChangesAsync();
            }
            return entity;
        }

        public async Task<bool> RemoveAsync(TEntity entity, bool autoSave = false)
        {
            DbContext.Set<TEntity>().Attach(entity);
            DbContext.Entry<TEntity>(entity).State = EntityState.Deleted;
            if (autoSave)
            {
                int result = await DbContext.SaveChangesAsync();
                return result > 0;
            }
            return false;
        }

        public async Task<bool> RemoveRangeAsync(List<TEntity> entitys, bool autoSave = false)
        {
            foreach(var entity in entitys)
            {
                DbContext.Set<TEntity>().Attach(entity);
                DbContext.Entry<TEntity>(entity).State = EntityState.Deleted;
            }
            if (autoSave)
            {
                int result = await DbContext.SaveChangesAsync();
                return result > 0;
            }
            return false;
        }
        public async Task<int> ComSqlCount(string sqlstr, object param = null)
        {
            return await DbContext.Database.GetDbConnection().ExecuteScalarAsync<int>(sqlstr,param);
        }
    }
}
