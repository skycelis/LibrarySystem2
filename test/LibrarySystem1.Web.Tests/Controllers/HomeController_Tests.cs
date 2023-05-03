using System.Threading.Tasks;
using LibrarySystem1.Models.TokenAuth;
using LibrarySystem1.Web.Controllers;
using Shouldly;
using Xunit;

namespace LibrarySystem1.Web.Tests.Controllers
{
    public class HomeController_Tests: LibrarySystem1WebTestBase
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