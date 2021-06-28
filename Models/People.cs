using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNetCore.Models
{
    public class People
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string name { get; set; }
        public string birth_year { get; set; }
        public string eye_color { get; set; }
        public string gender { get; set; }
        public string hair_color { get; set; }     
        public string height { get; set; }
        public string mass { get; set; }
        public string skin_color { get; set; }
        public string homeworld { get; set; }
        public virtual string films { get; set; }
        public virtual string species { get; set; }
        public virtual string starships { get; set; }
        public virtual string vehicles { get; set; }
        public string url { get; set; }
        public string created { get; set; }
        public string edited { get; set; }      


    }
}
