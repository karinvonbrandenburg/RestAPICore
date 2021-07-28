using Microsoft.EntityFrameworkCore;


namespace WebApiDotNetCore.Models
{
    public class WebApiDotNetCoreContext : DbContext
    {
        public WebApiDotNetCoreContext()
        {
        }
        public WebApiDotNetCoreContext(DbContextOptions<WebApiDotNetCoreContext> options)
            : base(options)
        {           
            Database.EnsureCreated();
        }

        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Root> Root { get; set; }
        public virtual DbSet<Planet> Planets { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Starship> Starships { get; set; }

        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options
            //.UseSqlServer(@"Data Source=whm01;Initial Catalog=WEBAPI; Integrated Security=True"); 
            options
            .UseSqlServer("WebAPIDatabase"); 
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.ApplyConfiguration.Add(new FilmConfigurations());          

            modelBuilder.Entity<Film>(e =>
                {
                    e.HasKey(m => m.ID)
                     .HasName("PK_Films");

                    e.Property(m => m.ID)
                    .UseIdentityColumn();

                    e.Property(m => m.title)
                     .IsRequired()
                     .HasMaxLength(250);

                }
            );

            modelBuilder.Entity<People>(e =>
            {
                e.HasKey(m => m.ID)
                 .HasName("PK_Peoples");

                e.Property(m => m.ID)
                .UseIdentityColumn();

                e.Property(m => m.name)
                 .IsRequired()
                 .HasMaxLength(250);

            }
           );

            modelBuilder.Entity<Root>(e =>
            {
                e.HasKey(m => m.ID)
                 .HasName("PK_Root");

                e.Property(m => m.ID)
                .UseIdentityColumn();

                e.Property(m => m.Films)
                 .IsRequired()
                 .HasMaxLength(250);

            }
           );

            modelBuilder.Entity<Planet>(e =>
            {
                e.HasKey(m => m.ID)
                 .HasName("PK_Planets");

                e.Property(m => m.ID)
                .UseIdentityColumn();

                e.Property(m => m.name)
                 .IsRequired()
                 .HasMaxLength(250);

            }
           );

            modelBuilder.Entity<Species>(e =>
            {
                e.HasKey(m => m.ID)
                 .HasName("PK_Species");

                e.Property(m => m.ID)
                .UseIdentityColumn();

                e.Property(m => m.name)
                 .IsRequired()
                 .HasMaxLength(250);

            }
           );

            modelBuilder.Entity<Starship>(e =>
            {
                e.HasKey(m => m.ID)
                 .HasName("PK_Starships");

                e.Property(m => m.ID)
                .UseIdentityColumn();

                e.Property(m => m.name)
                 .IsRequired()
                 .HasMaxLength(250);

            }
           );

            modelBuilder.Entity<Vehicle>(e =>
            {
                e.HasKey(m => m.ID)
                 .HasName("PK_Vehicle");

                e.Property(m => m.ID)
                .UseIdentityColumn();

                e.Property(m => m.name)
                 .IsRequired()
                 .HasMaxLength(250);

            }
           );
           modelBuilder.Entity<Film>()
               .HasData(
               new Film()
               {
                  ID  = 1,
                  title ="O império contra ataca"
               },
                new Film()
                {
                    ID = 2,
                    title = "O ataque dos clones"
                },
                 new Film()
                 {
                     ID = 3,
                     title = "Rogue 1"
                 });

            modelBuilder.Entity<People>()
               .HasData(
               new People()
               {
                   ID = 1,
                   name = "Luke Skywalker"
               },
                new People()
                {
                    ID = 2,
                    name = "Anakin Skywalker"
                },
                 new People()
                 {
                     ID = 3,
                     name = "Padmé Amidala"
                 });

            modelBuilder.Entity<Root>()
               .HasData(            
                 new Root()
                 {
                     ID = 1,
                     Films = "https://swapi.dev/api/films/",
                     People = "https://swapi.dev/api/people/",
                     Planets = "https://swapi.dev/api/planets/",
                     Species = "https://swapi.dev/api/species/",
                     Starships = "https://swapi.dev/api/starships/",
                     Vehicles = "https://swapi.dev/api/vehicles/"
                 });

            modelBuilder.Entity<Planet>()
               .HasData(
               new Planet()
               {
                   ID = 1,
                   name = "Tatooine"
               },
                new Planet()
                {
                    ID = 2,
                    name = "Hoth"
                },
                 new Planet()
                 {
                     ID = 3,
                     name = "Mustafar"
                 });

            modelBuilder.Entity<Starship>()
              .HasData(
              new Starship()
              {
                  ID = 1,
                  name = "Death Star"
              },
               new Starship()
               {
                   ID = 2,
                   name = "Falcon"
               },
                new Starship()
                {
                    ID = 3,
                    name = "Starcruiser"
                });

            modelBuilder.Entity<Species>()
              .HasData(
              new Species()
              {
                  ID = 1,
                  name = "Wookie"
              },
               new Species()
               {
                   ID = 2,
                   name = "Human"
               },
                new Species()
                {
                    ID = 3,
                    name = "Clawdites"
                });

            modelBuilder.Entity<Vehicle>()
             .HasData(
             new Vehicle()
             {
                 ID = 1,
                 name = "Sand Crawler"
             },
              new Vehicle()
              {
                  ID = 2,
                  name = "X-wing"
              },
               new Vehicle()
               {
                   ID = 3,
                   name = "Y-wing"
               });

          

        }








    }


}
