using AutoMapper;
using CADPLIS.Business;
using CADPLIS.Common;
using CADPLIS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly EFDbcontext efDbcontext;
        private readonly IMapper autoMapper;
        public UserController(ILogger<UserController> _logger, EFDbcontext _efDbcontext, IMapper _mapper)
        {
            logger = _logger;
            efDbcontext = _efDbcontext;
            autoMapper = _mapper;
            

        }
        [Route("GetList/{pageSize}&{pageIndex}")]
        [HttpGet]
        public Paginator<User> GetList(int pageSize, int pageIndex)
        {
            Paginator<User> page = new Paginator<User>();
            var datauser = efDbcontext.Users;
            var datasource= datauser.Skip(pageSize * pageIndex).Take(pageSize).AsNoTracking();
            page.pageSize = pageSize;
            page.pageIndex = pageIndex;
            page.pageCount = datauser.Count();
            page.data = datasource.ToList();
            return page;
        }

        [Route("GetUserCount")]
        [HttpGet]
        public int GetUserCount()
        {
            return efDbcontext.Users.Count();
        }


        [Route("GetUserListById/{Id}")]
        [HttpGet]
        public async Task<User> GetUserListById(string id)
        {
           return await efDbcontext.Users.FindAsync(id);
        }
        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] User userinfo)
        {
            if (ModelState.IsValid)
            {
                userinfo.Id = UniqueId.Generate();
                efDbcontext.Users.Add(userinfo);
                efDbcontext.SaveChanges();
            }
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] User userinfo)
        {
            if (ModelState.IsValid)
            {
                var userModel = efDbcontext.Users.FirstOrDefault(u => u.Id.Equals(userinfo.Id));
                if (userModel == null)
                {
                    return BadRequest();
                }
                userModel.UserName = userinfo.UserName;
                userModel.Age = userinfo.Age;

                efDbcontext.Users.Update(userModel);
                efDbcontext.SaveChanges();
            }
            return Ok();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginInput loginInput)
        {
            if (loginInput.UserName == "admin" && loginInput.Password == "123456")
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }
    }
}
