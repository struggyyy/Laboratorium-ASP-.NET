using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AlbumEntity
{
    [Key]
    public int AlbumId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    public string Band { get; set; }
    [Required]
    public string ? TrackList { get; set; }
    [Required]
    public uint Record { get; set; }
    [Required]
    public DateTime ReleaseDate { get; set; }
    [Required]
    public DateTime Duration { get; set; }

}

