using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Manatees.Models
{
    public class Movie
    {
        [Key]
        public int MovieId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        public int Year {get;set;}
        [Required]
        public string rating {get;set;}
        public List<Cast> Casts {get;set;}
    }
}