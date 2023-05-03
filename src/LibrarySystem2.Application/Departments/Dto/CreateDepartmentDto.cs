using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.AutoMapper;
using LibrarySystem2.Entities;

namespace LibrarySystem2.Departments.Dto
{
    [AutoMapFrom(typeof(DepartmentDto))]
    [AutoMapTo(typeof(Department))]

    public class CreateDepartmentDto
    {
        public string Name { get; set; }
    }
}
