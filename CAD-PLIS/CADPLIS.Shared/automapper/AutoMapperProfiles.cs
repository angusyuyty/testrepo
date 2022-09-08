using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Model.automapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<NavMenu, NavMenuDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserRoles, UserRolesDto>().ReverseMap();

            // CreateMap<List<NavMenu>, List<NavMenuDto>>().ReverseMap();
        }
    }
}
