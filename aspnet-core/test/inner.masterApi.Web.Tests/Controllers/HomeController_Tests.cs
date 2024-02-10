using System.Threading.Tasks;
using inner.masterApi.Models.TokenAuth;
using inner.masterApi.Web.Controllers;
using Shouldly;
using Xunit;

namespace inner.masterApi.Web.Tests.Controllers
{
    public class HomeController_Tests: masterApiWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}