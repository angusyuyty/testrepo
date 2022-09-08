using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.Functions
{
    public interface IFunctionRepository
    {
        Task InsertAsync(Function  function, bool autoSave = false);
        Task UpdateAsync(Function function, bool autoSave = false);
        Task DeleteAsync(Function function, bool autoSave = false);
        Task<Function> FindAsync(Expression<Func<Function, bool>> whereLambda);
        Task<List<Function>> GetListAsync(string fid, string ftype, string fname);
        Task<List<Function>> GetListAsync(Expression<Func<Function, bool>> whereLambda);
        Task<List<Function>> GetPageListAsync(int pageSize, int pageIndex, string fid, string ftype, string fname);
        Task<int> GetCountAsync(string fid, string ftype, string fname);
        Task<int> GetMaxDisplaySequence();

    }
}
