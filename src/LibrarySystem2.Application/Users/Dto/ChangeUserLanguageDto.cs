using System.ComponentModel.DataAnnotations;

namespace LibrarySystem2.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}