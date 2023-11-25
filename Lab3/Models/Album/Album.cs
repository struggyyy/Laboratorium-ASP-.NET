using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Lab3.Models.Album
{
    public class Album
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwę! ")]
        [StringLength(maximumLength: 100, ErrorMessage = "Zbyt długa nazwa, podaj mniej niż 100 znaków! ")]
        [Display(Name = "Nazwa albumu")]
        public string Name { get; set; }

        [StringLength(maximumLength: 50, ErrorMessage = "Serio taka długa nazwa zespołu? Podaj mniej niż 50 znaków! ")]
        [Display(Name = "Zespół")]
        public string Band { get; set; }

        [AllowNull]
        [Display(Name = "Tracklista")]
        public string TrackList { get; set; }

        [Range(0, 100)]
        [Display(Name = "Miejsce w notowaniach")]
        public uint Record { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data wydania")]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Czas trwania albumu")]
        public DateTime Duration { get; set; }

        [HiddenInput]
        [Display(Name = "Data dodania albumu do systemu")]
        public DateTime PublicationDate { get; set; }
    }
}
