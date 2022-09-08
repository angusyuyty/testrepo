using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.GeneralActionLogs
{
    public interface IGeneralActionLogAppService:IBaseAppService
    {
        Task Insert(GeneralActionLogDto model);
    }
}
