using Abp.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using static inner.masterApi.MangerFile.ManagerFile;

namespace inner.masterApi.MangerFile
{
    public interface IManagerFile : IApplicationService
    {
        Task<string> Upload([FromForm] IFormCollection file);
        Task<DownloadFile> Download(string file);
    }
}
