namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Series
    {
        public int SeriesId { get; set; }

        [StringLength(50)]
        public string SeriesName { get; set; }

        public int NumberOfSeasons { get; set; }

        public int Rating { get; set; }

        [StringLength(20)]
        public string AgeRating { get; set; }

        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
