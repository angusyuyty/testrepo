using AutoMapper;
using CADPLIS.Application.Contracts.Roles;
using CADPLIS.Domain;
using CADPLIS.Domain.Roles;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Roles
{
    public class RoleAppService : IRoleAppService
    {
        private readonly IMapper _autoMapper;
        private readonly PlisDbcontext _plisDbcontext;
        private readonly IRoleRepository _roleRepository;
        public RoleAppService(IMapper mapper, PlisDbcontext plisDbcontext, IRoleRepository roleRepository)
        {
            _autoMapper = mapper;
            _plisDbcontext = plisDbcontext;
            _roleRepository = roleRepository;
        }
        public async Task AddAsync(RoleInfoDto roleDto)
        {
            var model = _autoMapper.Map<RoleInfo>(roleDto);
            await _roleRepository.InsertAsync(model,true);
        }

        public async Task DeleteAsync(int id)
        {
            var model = await _roleRepository.FindAsync(i=>i.Id.Equals(id));
            if (model != null)
            {
                await _roleRepository.DeleteAsync(model, true);
            }
        }

        public async Task<Paginator<RoleInfoDto>> GetPageListAsync(int pageSize, int pageIndex, string roleId, string roleName)
        {
            var pageData = new Paginator<RoleInfoDto>(pageSize, pageIndex);
            var count = await _roleRepository.GetCountAsync(roleId, roleName);
            var result = await _roleRepository.GetPageListAsync(pageSize, pageIndex, roleId, roleName);
            pageData.pageCount = count;
            pageData.data = result.Any() ? _autoMapper.Map<List<RoleInfoDto>>(result) : new List<RoleInfoDto>(); ;
            return pageData;
        }

        public async Task UpdateAsync(RoleInfoDto roleDto)
        {
            var dbModel = _autoMapper.Map<RoleInfo>(roleDto);
            await _roleRepository.UpdateAsync(dbModel, true);
        }

        public async Task<List<RoleInfoDto>> GetAllRole()
        {
            var list = await _roleRepository.GetListAsync();
            var result = _autoMapper.Map<List<RoleInfoDto>>(list);
            return result;
        }

        public async Task<RoleInfoDto> GetByIdAsync(int id)
        {
            var model = await _roleRepository.FindAsync(i=>i.Id.Equals(id));
            var result = _autoMapper.Map<RoleInfoDto>(model);
            return result;
        }

        public async Task<RoleInfoDto> GetByRoleIdAsync(string roleId)
        {
            var model = await _roleRepository.FindAsync(u => u.RoleId.Equals(roleId));
            if (model != null)
            {
                var result = _autoMapper.Map<RoleInfoDto>(model);
                return result;
            }
            return await Task.FromResult(new RoleInfoDto());
        }
    }
}
