using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RealityProductor.Models
{
    public class Competitor
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Address { get; set; }
        [StringLength(8)]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}