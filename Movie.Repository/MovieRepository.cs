namespace Movie.Repository
{
    using Movie.Data;
    using Movie.Repository.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _dataContext;

        public MovieRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

    }
}
