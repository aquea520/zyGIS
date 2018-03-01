using System.ComponentModel.DataAnnotations;

namespace zyGIS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}