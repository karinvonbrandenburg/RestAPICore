using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNetCore.Models
{
    public class Root
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Films { get; set; }
        public string People { get; set; }
        public string Planets { get; set; }
        public string Species { get; set; }
        public string Starships { get; set; }     
        public string Vehicles { get; set; } 

    }
}
