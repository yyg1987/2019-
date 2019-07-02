using System.ComponentModel.DataAnnotations;

namespace YJ.PF.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}