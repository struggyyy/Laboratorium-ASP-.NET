using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab3.Models
{
    public class Album
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwę! ")]
        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długa nazwa, podaj mniej niż 100 znaków! ")]
        public string Name { get; set; }

        [StringLength(maximumLength: 50, ErrorMessage = "Serio taka długa nazwa zespołu? Podaj mniej niż 50 znaków! ")]
        public string Band { get; set; }

        [AllowNull]
        public string TrackList { get; set; }

        [Range(0, 100)]
        public uint Record { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "ReleaseDate")]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Duration")]
        public DateTime Duration { get; set; }
    }
}
