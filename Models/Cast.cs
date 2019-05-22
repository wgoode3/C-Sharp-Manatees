using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Manatees.Models
{
    public class Cast
    {
        [Key]
        public int CastId {get;set;}
        [Required]
        public string Role {get;set;}
        public int ActorId {get;set;}
        public Actor CastActor {get;set;}
        public int MovieId {get;set;}
        public Movie CastMovie {get;set;}
    }
}