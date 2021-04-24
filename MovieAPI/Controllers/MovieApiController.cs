using Microsoft.AspNetCore.Mvc;
using Movie.Entities;
using Movie.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieAPI.Controllers
{
    [Route("api/MovieAPI")]
    [ApiController]
    public class MovieAPIController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieAPIController(IMovieService movieService)
        {
            _movieService = movieService;
        }


        // GET: api/<MovieAPIController>
        [HttpGet("film/{id}")]
        public MovieEntity Get(int id)
        {
            var movie = _movieService.GetMovie(id);
            return movie;
        }

    }
}
