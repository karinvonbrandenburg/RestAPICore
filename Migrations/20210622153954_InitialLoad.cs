using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiDotNetCore.Migrations
{
    public partial class InitialLoad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    episode_id = table.Column<int>(type: "int", nullable: false),
                    opening_crawl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    producer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    release_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    starships = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    characters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    planets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    birth_year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eye_color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hair_color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    skin_color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    homeworld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    starships = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    climate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diameter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gravity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    orbital_period = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    population = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    residents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rotation_period = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surface_water = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terrain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Root",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Films = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    People = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Planets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Starships = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vehicles = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Root", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    average_height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    average_lifespan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    classification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    eye_colors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hair_colors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    homeworld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    people = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    skin_colors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MGLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cargo_capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consumables = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cost_in_credits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    crew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hyperdrive_rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    max_atmosphering_speed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    passengers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pilots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    starship_class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cargo_capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consumables = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cost_in_credits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edited = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    crew = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    length = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    max_atmosphering_speed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passengers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pilots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    films = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_class = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ID", "characters", "created", "director", "edited", "episode_id", "opening_crawl", "planets", "producer", "release_date", "species", "starships", "title", "url", "vehicles" },
                values: new object[,]
                {
                    { 1, null, null, null, null, 0, null, null, null, null, null, null, "O império contra ataca", null, null },
                    { 2, null, null, null, null, 0, null, null, null, null, null, null, "O ataque dos clones", null, null },
                    { 3, null, null, null, null, 0, null, null, null, null, null, null, "Rogue 1", null, null }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "ID", "birth_year", "created", "edited", "eye_color", "films", "gender", "hair_color", "height", "homeworld", "mass", "name", "skin_color", "species", "starships", "url", "vehicles" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, "Luke Skywalker", null, null, null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, "Anakin Skywalker", null, null, null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, "Padmé Amidala", null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "ID", "climate", "created", "diameter", "edited", "films", "gravity", "name", "orbital_period", "population", "residents", "rotation_period", "surface_water", "terrain", "url" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, "Tatooine", null, null, null, null, null, null, null },
                    { 2, null, null, null, null, null, null, "Hoth", null, null, null, null, null, null, null },
                    { 3, null, null, null, null, null, null, "Mustafar", null, null, null, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Root",
                columns: new[] { "ID", "Films", "People", "Planets", "Species", "Starships", "Vehicles" },
                values: new object[] { 1, "https://swapi.dev/api/films/", "https://swapi.dev/api/people/", "https://swapi.dev/api/planets/", "https://swapi.dev/api/species/", "https://swapi.dev/api/starships/", "https://swapi.dev/api/vehicles/" });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "ID", "average_height", "average_lifespan", "classification", "created", "designation", "edited", "eye_colors", "films", "hair_colors", "homeworld", "language", "name", "people", "skin_colors", "url" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, "Wookie", null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, "Human", null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, "Clawdites", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Starships",
                columns: new[] { "ID", "MGLT", "cargo_capacity", "consumables", "cost_in_credits", "created", "crew", "edited", "films", "hyperdrive_rating", "length", "manufacturer", "max_atmosphering_speed", "model", "name", "passengers", "pilots", "starship_class", "url" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, null, null, "Death Star", null, null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, null, null, "Falcon", null, null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, null, null, "Starcruiser", null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "ID", "cargo_capacity", "consumables", "cost_in_credits", "created", "crew", "edited", "films", "length", "manufacturer", "max_atmosphering_speed", "model", "name", "passengers", "pilots", "url", "vehicle_class" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, "Sand Crawler", null, null, null, null },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, "X-wing", null, null, null, null },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, "Y-wing", null, null, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Planets");

            migrationBuilder.DropTable(
                name: "Root");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Starships");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
