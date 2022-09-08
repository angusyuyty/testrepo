
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using CADPLIS.EntityFrameworkCore.WorkFlowDataAccess;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using AutoMapper;
using CADPLIS.Application.Contracts.WorkFlows;

namespace CADPLIS.Application.WorkFlows
{
    public class SettingsProvider : ISettingsProvider
    {
        private readonly PlisDbcontext _sampleContext;
        private readonly IMapper _autoMapper;
        public SettingsProvider(PlisDbcontext sampleContext, IMapper mapper)
        {
            _sampleContext = sampleContext;
            _autoMapper = mapper;
        }

        public SettingsDto GetSettings()
        {
            var model = new SettingsDto();

            var wfSheme = _sampleContext.WorkflowSchemes.FirstOrDefault(c => c.Code == model.SchemeName);
            if (wfSheme != null)
                model.WFSchema = wfSheme.Scheme;

            model.Employees = _autoMapper.Map<List<EmployeeDto>>(
                _sampleContext.Employees.Include(x => x.StructDivision)
                                        .Include(x => x.EmployeeRoles)
                                        .ThenInclude(x => x.Role)
                                        .ToList()
            );

            model.Roles = _autoMapper.Map<List<RoleDto>>(_sampleContext.WKRoles.ToList());

            var list = _sampleContext.StructDivisions.ToList();
            model.StructDivision = _autoMapper.Map<List<StructDivisionDto>>(list);

            return model;
            
        }
    }
}
