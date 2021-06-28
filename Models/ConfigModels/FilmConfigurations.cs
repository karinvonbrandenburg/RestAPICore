using System.Data.Entity.ModelConfiguration;
using WebApiDotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiDotNetCore.Models
{
    public class FilmConfigurations : EntityTypeConfiguration<Film>
    {
        public FilmConfigurations()
        {
            this.ToTable("Films");

            this.HasKey<int>(s => s.ID);

            this.Property(s => s.ID)
                .HasColumnName("PK_Films")
                .IsRequired();
                //.IsConcurrencyToken();
                

            this.Property(s => s.title)
                .IsRequired()
                .HasMaxLength(150);

            //this.Property(s => s.title)
            //    .IsConcurrencyToken();

            this.Property(s => s.characters)
              .IsOptional();

            this.Property(s => s.created)
              .IsOptional();

            this.Property(s => s.director)
               .IsOptional();

            this.Property(s => s.edited)
               .IsOptional();

            this.Property(s => s.episode_id)
               .IsOptional();
            

            this.Property(s => s.opening_crawl)
               .IsOptional();

            this.Property(s => s.planets)
               .IsOptional();

            this.Property(s => s.producer)
               .IsOptional();

            this.Property(s => s.release_date)
               .IsOptional();

            this.Property(s => s.starships)
               .IsOptional();

            this.Property(s => s.url)
               .IsOptional();

            this.Property(s => s.vehicles)
               .IsOptional();

            // Configure a one-to-one relationship between Student & StudentAddress
            //this.HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
            //    .WithRequired(ad => ad.Student); // Mark StudentAddress.Student property as required (NotNull).
        }
    }
}