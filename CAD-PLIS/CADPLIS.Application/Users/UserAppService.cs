using AutoMapper;
using CADPLIS.Application.Contracts.References;
using CADPLIS.Application.Contracts.Users;
using CADPLIS.Domain;
using CADPLIS.Domain.Users;
using CADPLIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADPLIS.Common;
using Microsoft.AspNetCore.Http;

namespace CADPLIS.Application.Users
{
    public class UserAppService : IUserAppService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserAppService(IMapper mapper,  IUserRepository userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task Insert(UserDto model)
        {
            var usermodel = _mapper.Map<User>(model);
            usermodel.Password = MD5Encryption.MD5Hash("Abcd1234");
            await _userRepository.InsertAsync(usermodel,true);
            model.Id = usermodel.Id;

        }

        public async Task Update(UserDto model)
        {
            var dbModel = _mapper.Map<User>(model);
            await _userRepository.ModifyAsync(dbModel,true);
        }
        public async Task<Paginator<UserDto>> GetListBySearchAsync(int pageSize, int pageIndex, string userId, int? uId, string email)
        {
            var c = _httpContextAccessor.HttpContext.User;
            //var x= _httpContextAccessor.HttpContext.Request.Headers;
            Paginator<UserDto> page = new Paginator<UserDto>();
            var result= await _userRepository.GetPageListAsync(pageSize,pageIndex,userId,uId,email);
            page.data = _mapper.Map<List<UserDto>>(result);
            page.pageCount = await _userRepository.GetCountAsync(userId,uId, email);
            page.pageSize = pageSize;
            page.pageIndex = pageIndex;
            return page;
        }
        public async Task<List<UserDto>> GetAllUser()
        {
            var userlist = await _userRepository.GetAllUserAsync(u => u.UserId != null);
            var result = _mapper.Map<List<UserDto>>(userlist);
            return result;
        }
        public async Task<UserDto> GetByIdAsync(int id)
        {
            var model = await _userRepository.FindAsync(u => u.Id.Equals(id));
            var result = _mapper.Map<UserDto>(model);         
            return result;
        }

        public async Task<UserDto> GetByLoginIdAsync(string userId)
        {
            var model = await _userRepository.FindAsync(u => u.UserId.Equals(userId));
            var result = _mapper.Map<UserDto>(model);
            return result;
        }



        public async Task DeleteAsync(int id)
        {
            var model = await _userRepository.FindAsync(u => u.Id.Equals(id));
            if (model != null)
            {
                await _userRepository.DeleteAsync(model,true);
            }
            
        }


    }
}
