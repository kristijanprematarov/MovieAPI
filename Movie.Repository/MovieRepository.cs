namespace Movie.Repository
{
    using Movie.Data;
    using Movie.Entities;
    using Movie.Repository.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MovieRepository : Repository<MovieEntity>, IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
