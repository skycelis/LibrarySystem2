using LibrarySystem2.Controllers
using LibrarySystem2.Departments;
using LibrarySystem2.Departments.Dto;
using System.Threading.Tasks;

namespace LibrarySystem2.Web.Controllers
{
    public class DepartmentsController : LibrarySystem2ControllerBase
    {
        private readonly IDepartmentAppService departmentAppService;

        public DepartmentsController(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }
        public async Task<ActionResult> Index()
        {
            var departments = await _departmentAppService.GetAllSync(new PagedDepartmentResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new DepartmentListViewModel
            {
                Depart
            }
            return View();
        }
    }
}
