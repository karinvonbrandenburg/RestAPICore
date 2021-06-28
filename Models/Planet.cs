using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNetCore.Models
{
    public class Planet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string climate { get; set; }
        public string created { get; set; }
        public string diameter { get; set; }
        public string edited { get; set; }     
        public string films { get; set; }
        public string gravity { get; set; }

        [Required]
        public string name { get; set; }
        public string orbital_period { get; set; }

        public string population { get; set; }
        public string residents { get; set; }
  
        public string rotation_period { get; set; }
  
        public virtual string surface_water { get; set; }
        public virtual string terrain { get; set; }

        public virtual string url { get; set; }




    }
}
