using Abp.Application.Services;
using inner.masterApi.Upload.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Upload
{
    public interface IUploadService : IApplicationService
    {
        Task<string> Upload([FromForm] IFormCollection file);
    }
}
