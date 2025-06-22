using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace inner.masterApi.Configuration
{
    public static class HostingEnvironmentExtensions
    {
        public static IConfigurationRoot GetAppConfiguration(this IWebHostEnvironment env)
        {
            return AppConfigurations.Get(
                Path.Combine(env.ContentRootPath, "src", "inner.masterApi.Web.Host"),
                    env.EnvironmentName,
                    env.IsDevelopment());
        }
    }
}
