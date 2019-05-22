using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manatees.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace Manatees.Controllers
{
    public class ManateeController : Controller
    {

        private ManateeContext context;

        public ManateeController(ManateeContext mc)
        {
            context = mc;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Movies = context.Movies.Include(m => m.Casts).ThenInclude(c => c.CastActor).ToList();
            ViewBag.Actors = context.Actresses.ToList();
            return View();
        }

        [Route("movie")]
        [HttpPost]
        public IActionResult CreateMovie(Movie m)
        {
            if(ModelState.IsValid)
            {
                context.Create(m);
            }
            return Redirect("/");
        }

        [Route("actor")]
        [HttpPost]
        public IActionResult CreateActor(Actor a)
        {
            if(ModelState.IsValid)
            {
                context.Create(a);
            }
            return Redirect("/");
        }

        [Route("cast")]
        [HttpPost]
        public IActionResult CreateCast(Cast c)
        {
            if(ModelState.IsValid)
            {
                context.Create(c);
            }
            return Redirect("/");
        }

    }
}
