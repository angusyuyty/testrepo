using AutoMapper;
using CADPLIS.Business;
using CADPLIS.Common.Email;
using CADPLIS.Model;
using CADPLIS.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private IConfiguration configRoot;
        private readonly ILogger<FileController> logger;
        private readonly EFDbcontext eFDbcontext;
        private readonly IMapper autoMapper;
        public FileController(IConfiguration _configRoot, ILogger<FileController> _logger, EFDbcontext _eFDbcontext, IMapper _mapper)
        {
            configRoot = _configRoot;
            logger = _logger;
            eFDbcontext = _eFDbcontext;
            autoMapper = _mapper;
        }
        [HttpGet]
        public void Get()
        {
            EmailSender.SendEmail("这是一个单元测试邮件", "这里是测试的内容", "xiongzhongkun@126.com", "Wetrial 微试云", "187213094@qq.com", "BestKF");
            logger.LogInformation("xxxxxxxxxxx");
        }



        [HttpPost]
        [Route("upload")]
        public void Upload([FromBody] FileData fileData)
        {
            string fileExt = Path.GetExtension(fileData.FileName);
            string fileName = $"{configRoot["NetWorkFile:FilePath"]}\\{Guid.NewGuid()}{fileExt}";

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(fileData.Data, 0, fileData.Data.Length);
            }
        }

        [Route("download")]
        [HttpGet]
        public IActionResult DownLoad()
        {
            var stream = new MemoryStream();
            using (var pck = new ExcelPackage(stream))
            {
                var ws = pck.Workbook.Worksheets.Add("供应商组织");
                ws.DefaultColWidth = 25;
                ws.DefaultRowHeight = 20;
                for (var i = 0; i < 10; i++)
                {
                    ws.Cells[1, i + 1].Value = "列" + i;
                    ws.SetValue(2, i + 1, "abc" + i);
                }
                pck.Save();

            }
            stream.Position = 0;
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "test.xlsx");
        }

        [Route("EFOper")]
        [HttpGet]
        public IEnumerable<User> EFOper()
        {
            var a = eFDbcontext.Users.ToList();
            return a;
        }
        [Route("automapper")]
        [HttpGet]
        public void automapper()
        {
            var navmenu1 = new NavMenu { MenuName = "首页" };
            var s = autoMapper.Map<List<NavMenuDto>>(new List<NavMenu> { navmenu1 });
        }
    }
}
