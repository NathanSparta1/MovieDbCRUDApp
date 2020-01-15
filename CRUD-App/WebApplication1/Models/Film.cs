namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Film
    {
        public int FilmId { get; set; }

        [Required]
        [StringLength(50)]
        public string FilmName { get; set; }

        public int? Duration { get; set; }

        [StringLength(50)]
        public string DirectorName { get; set; }

        public int Rating { get; set; }

        [StringLength(20)]
        public string AgeRating { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
