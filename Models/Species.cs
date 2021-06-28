using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNetCore.Models
{
    public class Species
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string average_height { get; set; }
        public string average_lifespan { get; set; }
        public string classification { get; set; }
        public string created { get; set; }     
        public string designation { get; set; }
        public string edited { get; set; }
        public string eye_colors { get; set; }
        public string hair_colors { get; set; }

        public string homeworld { get; set; }
        public string language { get; set; }
        public string name { get; set; }

        public string people { get; set; }

        public virtual string films { get; set; }
        public virtual string skin_colors { get; set; }
        public virtual string url { get; set; }

    }
}
