using System.Threading.Tasks;
using LibrarySystem2.Models.TokenAuth;
using LibrarySystem2.Web.Controllers;
using Shouldly;
using Xunit;

namespace LibrarySystem2.Web.Tests.Controllers
{
    public class HomeController_Tests: LibrarySystem2WebTestBase
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