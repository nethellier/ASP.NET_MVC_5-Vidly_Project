﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers {
    public class MoviesController : Controller {
        // GET: Movies/Random
        public ActionResult Random() //was Index
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }
        
    }
}