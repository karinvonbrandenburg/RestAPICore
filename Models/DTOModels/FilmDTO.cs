using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNetCore.Models
{
    public class FilmDTO
    {       

        [Required]
        public string title { get; set; }
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }       
       

    }
}
