using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain
{
   public interface IUnitOfWork
    {
        Task SaveChange();
        Task SaveChangeAsync();
    }
}
