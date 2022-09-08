using CADPLIS.Domain;
using CADPLIS.Domain.Functions;
using CADPLIS.Domain.NavMenus;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CADPLIS.EntityFrameworkCore.Functions
{
    public class FunctionRepository : EfBaseRepository<Function>, IFunctionRepository
    {
        public FunctionRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {

        }

        public async Task DeleteAsync(Function function, bool autoSave = false)
        {
            await RemoveAsync(function, autoSave);
        }

        public async Task<Function> FindAsync(Expression<Func<Function, bool>> whereLambda)
        {
            var result = await FindModelAsync(whereLambda);
            return result;
        }

        public async Task<int> GetCountAsync(string fid, string ftype, string fname)
        {
            var query = GetListQuery(fid, ftype, fname);

            var totalCount = await query.CountAsync();

            return totalCount;
        }

        public async Task<List<Function>> GetListAsync(string fid, string ftype, string fname)
        {
            var result = GetListQuery(fid, ftype, fname);
            return await result.ToListAsync();
        }
        public async Task<List<Function>> GetListAsync(Expression<Func<Function, bool>> whereLambda)
        {
          
            return await DbSet.Where(whereLambda).ToListAsync();
        }
        public async Task<List<Function>> GetPageListAsync(int pageSize, int pageIndex, string fid, string ftype, string fname)
        {
            var query = GetListQuery(fid, ftype, fname);
            var result = await query.PageBy(pageSize * pageIndex, pageSize).ToListAsync();
            return result;
        }

        public async Task InsertAsync(Function function, bool autoSave = false)
        {
            await AddAsync(function, autoSave);
        }

        public async Task UpdateAsync(Function function, bool autoSave = false)
        {
            await EditAsync(function, autoSave);
        }
        public async Task<int> GetMaxDisplaySequence()
        {
            return await DbSet.AsNoTracking().Where(u=>u.DisplaySequence.HasValue).MaxAsync( u => u.DisplaySequence.Value);
        }
        protected virtual IQueryable<Function> GetListQuery(string fid, string ftype, string fname)
        {
            return DbSet.AsNoTracking()
                .WhereIf(!string.IsNullOrEmpty(fid), i => i.FunctionId.Contains(fid))
                .WhereIf(!string.IsNullOrEmpty(ftype), i => i.FunctionType.Contains(ftype))
                .WhereIf(!string.IsNullOrEmpty(fname), i => i.FunctionDescription.Contains(fname));
        }
    }
}
