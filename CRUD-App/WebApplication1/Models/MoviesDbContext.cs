namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MoviesDbContext : DbContext
    {
        public MoviesDbContext()
            : base("name=MoviesDbContext")
        {
        }

        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Series> Series { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>()
                .Property(e => e.DirectorName)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.GenreName)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Films)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Series)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);
        }
    }
}
