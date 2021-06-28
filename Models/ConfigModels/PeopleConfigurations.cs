using System.Data.Entity.ModelConfiguration;
using WebApiDotNetCore.Models;

namespace WebApiDotNetCore.Models
{
    public class PeopleConfigurations : EntityTypeConfiguration<People>
    {
        public PeopleConfigurations()
        {
            this.Property(s => s.ID)
               .IsRequired();

            this.Property(s => s.mass)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(s => s.name)
              .IsOptional();

            this.Property(s => s.birth_year)
              .IsOptional();

            this.Property(s => s.created)
               .IsOptional();

            this.Property(s => s.edited)
               .IsOptional();

            this.Property(s => s.eye_color)
               .IsOptional();
            

            this.Property(s => s.films)
               .IsOptional();

            this.Property(s => s.gender)
               .IsOptional();

            this.Property(s => s.hair_color)
               .IsOptional();

            this.Property(s => s.homeworld)
               .IsOptional();

            this.Property(s => s.eye_color)
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