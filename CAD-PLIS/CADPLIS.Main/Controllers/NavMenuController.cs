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
    public class NavMenuController : ControllerBase
    {
        private readonly ILogger<NavMenuController> logger;
        private readonly EFDbcontext efDbcontext;
        private readonly IMapper autoMapper;
        public NavMenuController(ILogger<NavMenuController> _logger, EFDbcontext _efDbcontext, IMapper _mapper)
        {
            logger = _logger;
            efDbcontext = _efDbcontext;
            autoMapper = _mapper;
        }
        [Route("Get")]
        [HttpGet]
        [DisableAuditing]
        public IEnumerable<NavMenu> Get()
        {
          var method=  HttpContext.Request.Method;
            return efDbcontext.NavMenu.Where(u => u.IsDeleted == false).AsNoTracking();
        }

        [Route("Get/{id}")]
        [HttpGet]
        public async Task<NavMenu> GetById(string id)
        {
            return await efDbcontext.NavMenu.FindAsync(id);
        }


        [Route("GetWithChild")]
        [HttpGet]
        public NavMenuDto GetWithChild()
        {
            var navMenuList = efDbcontext.NavMenu.Where(u => u.IsDeleted == false).ToList();
            var navMenuDtoList = autoMapper.Map<List<NavMenuDto>>(navMenuList);

            var firstMenu = navMenuDtoList.Where(u => string.IsNullOrEmpty(u.ParentId)).ToList();
            SetMenuWithChildren(firstMenu, navMenuDtoList);

            var navMenuDto = new NavMenuDto
            {
                MenuName = "Menus",
                Children = firstMenu.AsEnumerable()
            };
            return navMenuDto;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] NavMenu navMenu)
        {
            if (ModelState.IsValid)
            {
                navMenu.Id = UniqueId.Generate();
                navMenu.CreatedBy = "10000";//to do
                navMenu.CreatedTime = DateTime.Now;
                efDbcontext.NavMenu.Add(navMenu);
                efDbcontext.SaveChanges();
            }
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody] NavMenu navMenu)
        {
            if (ModelState.IsValid)
            {
                var dbModel = efDbcontext.NavMenu.FirstOrDefault(u => u.Id.Equals(navMenu.Id));
                var parentId = dbModel.ParentId;

                bool isChangeParentId = navMenu.ParentId == dbModel.ParentId;
                if (dbModel == null)
                {
                    return BadRequest();
                }
                dbModel.MenuName = navMenu.MenuName;
                dbModel.OrderNo = navMenu.OrderNo;
                dbModel.ParentId = navMenu.ParentId;
                dbModel.Icon = navMenu.Icon;
                dbModel.RouteUrl = navMenu.RouteUrl;
                dbModel.Permission = navMenu.Permission;
                dbModel.UpdatedBy = "10000";//to do
                dbModel.UpdatedTime = DateTime.Now;
                efDbcontext.NavMenu.Update(dbModel);

                if (isChangeParentId)
                {
                    //now menu's child menu
                    var navMenuChilds = efDbcontext.NavMenu.Where(u => u.ParentId.Equals(navMenu.Id));

                    string parentsParentId = null;
                    if (parentId != null)
                    {
                        //now menu's parent
                        var navMenuParent = efDbcontext.NavMenu.FirstOrDefault(u => u.Id.Equals(parentId));
                        parentsParentId = navMenuParent != null ? navMenuParent.ParentId : null;
                    }

                    foreach (var item in navMenuChilds)
                    {
                        item.ParentId = parentsParentId;
                    }
                }
               

                efDbcontext.SaveChanges();
            }
            return Ok();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete([FromRoute] string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("the delete object can not be null!");
            }
            var dbModel = efDbcontext.NavMenu.FirstOrDefault(u => u.Id.Equals(id));
            dbModel.IsDeleted = true;
            efDbcontext.NavMenu.Update(dbModel);
            efDbcontext.SaveChanges();
            return Ok();
        }


        void SetMenuWithChildren(List<NavMenuDto> parentMenus, List<NavMenuDto> allMenus)
        {
            foreach (var item in parentMenus)
            {
                var subMenus = allMenus.Where(u =>!string.IsNullOrEmpty(u.ParentId)&& u.ParentId.Equals(item.Id)).ToList();
                if (subMenus.Any())
                {
                    item.Children = subMenus;
                    SetMenuWithChildren(subMenus, allMenus);
                }
            }
        }


        [HttpGet]
        [Route("show")]
        public void Show(string id,string name)
        {
            
        }
    }
}
