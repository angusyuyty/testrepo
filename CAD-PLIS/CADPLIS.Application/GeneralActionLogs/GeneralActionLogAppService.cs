using AutoMapper;
using CADPLIS.Application.Contracts.GeneralActionLogs;
using CADPLIS.Domain.GeneralActionLogs;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.GeneralActionLogs
{
    public class GeneralActionLogAppService: IGeneralActionLogAppService
    {
        private readonly IMapper _mapper;
        private readonly PlisDbcontext _plisDbcontext;
        public GeneralActionLogAppService(IMapper mapper, PlisDbcontext plisDbcontext)
        {
            _mapper = mapper;
            _plisDbcontext = plisDbcontext;
        }
        public async Task Insert(GeneralActionLogDto model)
        {
            var gmodel = _mapper.Map<GeneralActionLog>(model);
            _plisDbcontext.GeneralActionLogs.Add(gmodel);
            await _plisDbcontext.SaveChangesAsync();
        }
    }
}
