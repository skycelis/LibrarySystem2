using System.Threading.Tasks;
using LibSystem.Models.TokenAuth;
using LibSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace LibSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: LibSystemWebTestBase
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