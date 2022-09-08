using AutoMapper;
using CADPLIS.Application.Contracts.Files;
using CADPLIS.Common.Email;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace CADPLIS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private IConfiguration _configRoot;
        private readonly ILogger<FileController> _logger;
        private readonly IMapper _autoMapper;
        private readonly IEmailSender _emailSender;
        public FileController(IConfiguration configRoot, ILogger<FileController> logger, IMapper mapper, IEmailSender emailSender)
        {
            _configRoot = configRoot;
            _logger = logger;
            _autoMapper = mapper;
            _emailSender = emailSender;
        }
        [HttpGet]
        [Route("Get")]
        public void Get()
        {
            _emailSender.SendEmail("This is a unit test email", "Here's the test",  "187213094@qq.com");
            _logger.LogInformation("xxxxxxxxxxx");
        }



        [HttpPost]
        [Route("upload")]
        public void Upload([FromBody] List<FileData> fileDatas)
        {
            foreach (var fileData in fileDatas)
            {
                string fileExt = Path.GetExtension(fileData.FileName);
                string fileName = $"{_configRoot["NetWorkFile:FilePath"]}\\{Guid.NewGuid()}{fileExt}";
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fs.Write(fileData.Data, 0, fileData.Data.Length);
                }
            }
        }

        [Route("download")]
        [HttpGet]
        public IActionResult DownLoad()
        {
            var stream = new MemoryStream();
            using (var pck = new ExcelPackage(stream))
            {
                var ws = pck.Workbook.Worksheets.Add("Supplier organization");
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
    }
}
