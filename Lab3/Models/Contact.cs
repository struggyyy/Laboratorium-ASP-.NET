using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab3.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imię, podaj mniej niż 50 znaków! ")]
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [EmailAddress]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "Numer telefonu")]
        public string Phone { get; set; }
        [AllowNull]
        [Display(Name = "Data urodzenia")]
        public DateTime? Birth { get; set; }
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
    }
}
