using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CADPLIS.WebSite.Pages
{
    public partial class Upload : ComponentBase
    {
        //async Task FilesReady(IMatFileUploadEntry[] files)
        //{
        //    foreach (var formFile in files)
        //    {
        //        if (formFile.Size > 0)
        //        {
        //            using (var stream = new MemoryStream())
        //            {
        //                await formFile.WriteToStreamAsync(stream);
        //                using (FileStream newFile = new FileStream("wwwroot\\uploads\\" + formFile.Name, FileMode.Create, FileAccess.Write))
        //                {
        //                    stream.WriteTo(newFile);
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
