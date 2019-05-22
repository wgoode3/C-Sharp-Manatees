using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Manatees.Models
{
    public class Actor
    {
        [Key]
        public int ActorId {get;set;}
        [Required]
        public string Name {get;set;}
        public List<Cast> Casts {get;set;}
    }
}