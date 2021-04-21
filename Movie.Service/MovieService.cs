namespace Movie.Service
{
    using Movie.Entities;
    using Movie.Repository.Interfaces;
    using Movie.Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MovieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public MovieEntity GetMovie(int id)
        {
            return _unitOfWork.Movies.Get(id);
        }
    }
}
