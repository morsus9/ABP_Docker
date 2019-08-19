using System.ComponentModel.DataAnnotations;

namespace ABPDocker.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}