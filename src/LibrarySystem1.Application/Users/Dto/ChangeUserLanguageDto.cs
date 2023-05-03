using System.ComponentModel.DataAnnotations;

namespace LibrarySystem1.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}