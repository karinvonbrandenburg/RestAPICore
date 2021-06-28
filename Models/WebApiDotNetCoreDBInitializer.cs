using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace WebApiDotNetCore.Models
{
    public class WebApiDotNetCoreDBInitializer : DropCreateDatabaseAlways<WebApiDotNetCoreContext>
    {
        protected override void Seed(WebApiDotNetCoreContext context)
        {
            IList<Film> films = new List<Film>();

            films.Add(new Film() { tile = "Filme 1" });
            films.Add(new Film() { tile = "Filme 2" });
            films.Add(new Film() { tile = "Filme 3" });
            films.Add(new Film() { tile = "Filme 4" });
            films.Add(new Film() { tile = "Filme 5" });

            context.Films.AddRange(films);

            base.Seed(context);
        }
    }
}
