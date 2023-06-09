﻿using Abp.AutoMapper;
using LibrarySystem2.Authentication.External;

namespace LibrarySystem2.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
