﻿using Abp.AutoMapper;
using LibrarySystem1.Authentication.External;

namespace LibrarySystem1.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
