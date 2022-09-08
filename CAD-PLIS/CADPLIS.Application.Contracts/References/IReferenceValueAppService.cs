using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Contracts.References
{
    public interface IReferenceValueAppService:IBaseAppService
    {
        Task Insert(ReferenceValueDto model);
        int GetMaxValue(string referenceType);
    }
}
