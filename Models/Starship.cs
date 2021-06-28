using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDotNetCore.Models
{
    public class Starship
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string MGLT { get; set; }
        public string cargo_capacity { get; set; }
        public string consumables { get; set; }
        public string cost_in_credits { get; set; }     
        public string created { get; set; }
        public string crew { get; set; }
        public string edited { get; set; }
        public string hyperdrive_rating { get; set; }

        public string length { get; set; }
        public string manufacturer { get; set; }
        public string max_atmosphering_speed { get; set; }
        public string model { get; set; }

        [Required]
        public virtual string name { get; set; }
        public virtual string passengers { get; set; }
        public virtual string films { get; set; }      
        public virtual string pilots { get; set; }
        public virtual string starship_class { get; set; }
        public virtual string url { get; set; }


    }
}
