using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Domain.GeneralActionLogs
{
    public interface IGeneralActionLogRepository
    {
        Task InsertAsync(GeneralActionLog model, bool autoSave = false);
    }
}
