using System.ComponentModel.DataAnnotations;

namespace LibSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}