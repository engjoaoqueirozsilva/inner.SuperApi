using Abp.IO.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace inner.masterApi.Upload
{
    public class UploadService : IUploadService
    {
        [HttpPost("Upload")]
        public async Task<string> Upload([FromForm] IFormCollection files)
        {
            if (files == null)
                return null;


            ManagedFiles(files.Files);

            return "Arquivos Manipulados com Sucesso!!";
        }

        private async void ManagedFiles(IFormFileCollection files)
        {
            try
            {
                string path = Path.Combine(@"C:\inner\MoVE\");
                string fileTextDate = DateTime.Now.ToString().Replace("/","").Replace(":","").Replace(" ", "_");

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
    }
}
