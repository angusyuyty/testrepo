using AutoMapper;
using CADPLIS.Application.Contracts.Groups;
using CADPLIS.Domain;
using CADPLIS.Domain.Groups;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Application.Groups
{
    public class GroupAppService: IGroupAppService
    {
        private readonly IMapper _mapper;
        private readonly IGroupRepository _groupRepository;
        public GroupAppService(IMapper mapper,  IGroupRepository groupRepository)
        {
            _mapper = mapper;
            _groupRepository = groupRepository;
        }
        public async Task Insert(GroupDto model)
        {
            var gmodel = _mapper.Map<Group>(model);
            await _groupRepository.InsertAsync(gmodel,true);
            model.Id = gmodel.Id;
        }

        public async Task Update(GroupDto model)
        {
            var dbModel = _mapper.Map<Group>(model);
            await _groupRepository.ModifyAsync(dbModel,true);
        }
        public async Task<Paginator<GroupDto>> GetListBySearchAsync(int pageSize, int pageIndex, string groupId,  string name)
        {
            Paginator<GroupDto> page = new Paginator<GroupDto>();
            var result =await  _groupRepository.GetPageListAsync(pageSize, pageIndex,groupId,name);
            page.data = _mapper.Map<List<GroupDto>>(result);
            page.pageCount = await _groupRepository.GetCountAsync(groupId, name);
            page.pageSize = pageSize;
            page.pageIndex = pageIndex;
            return page;
        }

        public async Task<List<GroupDto>> GetAllGroup(string gId)
        {
           
            var list = await _groupRepository.GetAllGroupAsync(gId);
            var result = _mapper.Map<List<GroupDto>>(list);
            return result;
        }
        public async Task<GroupDto> GetByIdAsync(int id)
        {
            var model = await _groupRepository.FindAsync(u=>u.Id.Equals(id));
            var result = _mapper.Map<GroupDto>(model);
            return result;
        }
        public async Task DeleteAsync(int id)
        {
            var model = await _groupRepository.FindAsync(u => u.Id.Equals(id));
            if (model != null)
            {
               await _groupRepository.DeleteAsync(model,true);
            }
        }

    }
}
