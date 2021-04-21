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
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MovieAPIController>/5
        [HttpGet("{id}")]
        public MovieEntity Get(int id)
        {
            return _movieService.GetMovie(id);
        }

        // POST api/<MovieAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MovieAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
