
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADPLIS.Application.Contracts.WorkFlows;

namespace CADPLIS.EntityFrameworkCore.WorkFlowDataAccess
{
    public interface ISettingsProvider
    {
        SettingsDto GetSettings();
    }
}
