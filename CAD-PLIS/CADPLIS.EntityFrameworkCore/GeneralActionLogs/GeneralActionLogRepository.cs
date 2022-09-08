using CADPLIS.Domain.GeneralActionLogs;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.GeneralActionLogs
{
    public class GeneralActionLogRepository: EfBaseRepository<GeneralActionLog>, IGeneralActionLogRepository
    {
        public GeneralActionLogRepository(PlisDbcontext plisDbcontext) : base(plisDbcontext)
        { 
        }
        public async Task InsertAsync(GeneralActionLog model, bool autoSave = false)
        {
            await AddAsync(model, autoSave);
        }
    }
}
