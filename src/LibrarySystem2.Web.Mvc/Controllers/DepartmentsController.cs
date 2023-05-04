using LibrarySystem2.Controllers;
using LibrarySystem2.Departments;
using LibrarySystem2.Departments.Dto;
using LibrarySystem2.Web.Models.Departments;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem2.Web.Controllers
{
    public class DepartmentsController : LibrarySystem2ControllerBase
    {
        private readonly IDepartmentAppService _departmentAppService;

        public DepartmentsController(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }
        public async Task<IActionResult> Index()
        {
            var departments = await _departmentAppService.GetAllAsync(new PagedDepartmentResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new DepartmentListViewModel()
            {
                Departments = departments.Items.ToList()
            };

            return View(model);
        }
    }
}
