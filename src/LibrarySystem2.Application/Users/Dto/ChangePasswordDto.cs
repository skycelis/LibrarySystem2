﻿using System.ComponentModel.DataAnnotations;

namespace LibrarySystem2.Users.Dto
{
    public class ChangePasswordDto
    {
        [Required]
        public string CurrentPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}
