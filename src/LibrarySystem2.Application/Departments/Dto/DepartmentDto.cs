﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibrarySystem2.Authorization.Users;
using LibrarySystem2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem2.Departments.Dto
{
    [AutoMapFrom(typeof(Department))]
    public class DepartmentDto : EntityDto<int>
    {
        public string Name { get; set; } 
       
    }
}
