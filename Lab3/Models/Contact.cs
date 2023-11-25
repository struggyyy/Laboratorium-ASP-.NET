using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab3.Models
{
    public enum Priority
    {
        [Display(Name = "Niski")]
        Low,
        [Display(Name = "Normalny")]
        Normal,
        [Display(Name = "Pilny")]
        Urgent
    }

    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Musisz podać imię!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długie imię, podaj mniej niż 50 znaków")]
        public string Name { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "Numer telefonu")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data urodzenia")]
        public DateTime? Birth { get; set; }
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }
        public int? OrganizationId { get; set; }
        [ValidateNever]
        public List<SelectListItem> OrganizationList { get; set; }
    }
}
