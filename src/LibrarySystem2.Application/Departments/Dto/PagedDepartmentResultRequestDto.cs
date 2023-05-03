using System;
using Abp.Application.Services.Dto;

namespace LibrarySystem2.Departments.Dto
{
    public class PagedDepartmentResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }

        public bool? IsActive { get; set; }
    }
}
