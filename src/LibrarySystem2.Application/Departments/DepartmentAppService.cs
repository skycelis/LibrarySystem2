using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem2.Entities;
using LibrarySystem2.Departments.Dto;
using Abp.Domain.Entities;

namespace LibrarySystem2.Departments
{
    public class DepartmentAppService : AsyncCrudAppService<Department, DepartmentDto, int, PagedDepartmentResultRequestDto, CreateDepartmentDto, DepartmentDto>, IDepartmentAppService

    {
        public DepartmentAppService(IRepository<Department, int> repository) : base(repository)
        {
        }

        public override Task<DepartmentDto> CreateAsync(CreateDepartmentDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<DepartmentDto>> GetAllSync(PagedDepartmentResultRequestDto input)
        {
            return base.GetAllAsync 
        }
        public override Task<DepartmentDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }
    }

}
