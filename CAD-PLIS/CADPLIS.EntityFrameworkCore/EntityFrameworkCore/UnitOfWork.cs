using CADPLIS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityFrameworkCore
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlisDbcontext _plisDbcontext;
        public UnitOfWork(PlisDbcontext plisDbcontext)
        {
            _plisDbcontext = plisDbcontext;
        }
        public async Task SaveChangeAsync()
        {
            await _plisDbcontext.SaveChangesAsync();
        }
        public Task SaveChange()
        {
            _plisDbcontext.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
