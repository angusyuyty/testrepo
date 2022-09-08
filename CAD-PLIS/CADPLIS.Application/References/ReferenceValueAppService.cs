using AutoMapper;
using CADPLIS.Application.Contracts.References;
using CADPLIS.Domain.References;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.References
{
    public class ReferenceValueAppService: IReferenceValueAppService
    {
        private readonly IMapper _autoMapper;
        private readonly PlisDbcontext _plisDbcontext;
        public ReferenceValueAppService(IMapper mapper, PlisDbcontext plisDbcontext)
        {
            _autoMapper = mapper;
            _plisDbcontext = plisDbcontext;
        }
        public async Task Insert(ReferenceValueDto model)
        {
            _plisDbcontext.ReferenceValues.Add(_autoMapper.Map<ReferenceValue>(model));
            await _plisDbcontext.SaveChangesAsync();
        }
        public int GetMaxValue(string referenceType)
        {
            int value = 0;
            var result = _plisDbcontext.ReferenceValues.Where(r => r.ReferenceType == referenceType).Select(r => r.Value);
            if (result.Count() > 0)
            {
                 value = result.Max();
            }
            return value;
        }

    }
}
