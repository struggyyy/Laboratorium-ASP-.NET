using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab3.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz podać imię! ")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imię, podaj mniej niż 50 znaków! ")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [AllowNull]
        public DateTime? Birth { get; set; }
    }
}
