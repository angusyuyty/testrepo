using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.MCApplications
{
    public interface IMCApplicationRepository
    {
        Task<int> GetCount(string sqlstr, object param = null);
    }
}
