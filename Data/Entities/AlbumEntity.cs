using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("albums")]
    public class AlbumEntity
    {
        [Key]
        public int AlbumId { get; set; }
        [Column("name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Band { get; set; }
        public string TrackList { get; set; }
        public uint Record { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime Duration { get; set; }

    }
}
