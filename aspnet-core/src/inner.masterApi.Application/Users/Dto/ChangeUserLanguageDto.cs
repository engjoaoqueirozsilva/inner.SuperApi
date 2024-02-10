using System.ComponentModel.DataAnnotations;

namespace inner.masterApi.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}