using Abp.IO.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace inner.masterApi.MangerFile
{
    public class ManagerFile : IManagerFile
    {
        [HttpGet("AllFiles")]
        public async Task<List<string>> AllFiles()
        {
            var files = Directory.GetFiles(Path.Combine(@"C:\inner\MoVE\upDoc"));

            List<string> names = new List<string>();
            foreach (var file in files) 
            {
                names.Add(file.Replace("C:\\inner\\MoVE\\upDoc\\", ""));
            }
            return names;
        }

        [HttpGet("Download")]
        public async Task<DownloadFile> Download(string file)
        {
            if (file == null)
                return null;

            var files = Directory.GetFiles(Path.Combine(@"C:\inner\MoVE\upDoc"));
            DownloadFile downloadFile = new();
            if (files != null)
            {
                if (files.Count() > 0)
                {
                    foreach (var arq in files)
                    {
                        if (Path.GetFileName(arq) == file)
                        {
                            downloadFile.buffer = Convert.ToBase64String(File.ReadAllBytes(arq), 0, File.ReadAllBytes(arq).Length);
                            downloadFile.name = Path.GetFileName(arq);

                            var provider = new FileExtensionContentTypeProvider();
                            if(provider.TryGetContentType(arq, out var contenttype))
                            {
                                downloadFile.contentType = contenttype;
                            }
                            else
                            {
                                downloadFile.contentType  = "application/octet-stream";
                            }

                        }
                    }
                }
            }


            return downloadFile;

        }

        [HttpPost("Upload")]
        public async Task<string> Upload([FromForm] IFormCollection files)
        {
            if (files == null)
                return null;


            HandleUpload(files.Files);

            return "Arquivos Manipulados com Sucesso!!";
        }

        private async void HandleUpload(IFormFileCollection files)
        {
            try
            {
                string path = Path.Combine(@"C:\inner\MoVE\");
                string fileTextDate = DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "_");

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        if (Directory.Exists(path))
                        {
                            Stream stream = null;

                            stream = file.OpenReadStream();

                            FileStream fileStream = new FileStream(string.Format("{0}{1}_{2}", path, fileTextDate, file.FileName), FileMode.Create, FileAccess.Write);

                            var fileByteArray = stream.GetAllBytes();

                            var fileByteArrayLength = fileByteArray.Length;

                            string bytesString = Convert.ToBase64String(fileByteArray, 0, fileByteArrayLength);

                            fileStream.Write(fileByteArray, 0, fileByteArrayLength);

                            stream.Dispose();
                            fileStream.Dispose();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public class DownloadFile
        {
            public string buffer { get; set;}
            public string name { get; set; }
            public string contentType { get; set; }
        }
    }
}

