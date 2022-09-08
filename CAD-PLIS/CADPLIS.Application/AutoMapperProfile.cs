using AutoMapper;
using CADPLIS.Application.Contracts.Logs;
using CADPLIS.Application.Contracts.NavMenus;

using CADPLIS.Application.Contracts.WorkFlows;
using CADPLIS.Domain.Logs;
using CADPLIS.Domain.NavMenus;

using CADPLIS.Domain.WorkFlows;
using CADPLIS.Application.Contracts.Accounts;
using CADPLIS.Application.Contracts.Monitorings;
using CADPLIS.Domain.Identity;
using CADPLIS.Domain.AuditInfos;
using CADPLIS.Domain.Functions;
using CADPLIS.Domain.Users;
using CADPLIS.Application.Contracts.Functions;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Domain.Roles;
using CADPLIS.Domain.Groups;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Domain.GeneralActionLogs;
using CADPLIS.Application.Contracts.GeneralActionLogs;
using CADPLIS.Domain.SystemAuditLogs;

namespace CADPLIS.Application
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PlisNavMenu, NavMenuDto>().ReverseMap();
            CreateMap<StructDivision, StructDivisionDto>();
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Role, RoleDto>();
            CreateMap<EmployeeRole, EmployeeRoleDto>();
            CreateMap<Document, DocumentDto>();
            CreateMap<LogRecordDetail, LogRecordDetailDto>().ReverseMap();
            CreateMap<ApplicationUser, ApplicationUserDto>();
            CreateMap<AuditInfo, AuditInfoDto>().ReverseMap();
            CreateMap<GroupInfo, GroupInfoDto>().ReverseMap();
            CreateMap<Function, FunctionDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<RoleInfo, CADPLIS.Application.Contracts.Roles.RoleInfoDto>();
            CreateMap<UserRole, UserRoleDto>().ReverseMap();
            CreateMap<RoleInfo, CADPLIS.Application.Contracts.Roles.RoleInfoDto>().ReverseMap();
            CreateMap<Group, GroupDto>().ReverseMap();
            CreateMap<UserRoleGroup, UserRoleGroupDto>().ReverseMap();
            CreateMap<GroupAccessibleFunction, GroupAccessibleFunctionDto>().ReverseMap();
            CreateMap<GeneralActionLog, GeneralActionLogDto>().ReverseMap();
            CreateMap<WorkFlowDocument, WorkFlowDocumentDto>().ReverseMap();
        }
    }
}
