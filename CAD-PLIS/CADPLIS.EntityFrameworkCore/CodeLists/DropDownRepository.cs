using CADPLIS.Domain.CodeLists;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.CodeLists
{
   public class DropDownRepository:EfBaseRepository<DropDownList>,IDropDownRepository
    {
        public DropDownRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        {

        }

        public async Task<List<DropDownList>> GetListByType(string type)
        {
            var list = await FindListAsync(u => u.Type.Equals(type));
            return list;
        }
    }
}
