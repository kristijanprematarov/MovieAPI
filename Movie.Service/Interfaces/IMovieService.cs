namespace Movie.Service.Interfaces
{
    using Movie.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IMovieService
    {
        MovieEntity GetMovie(int id);
    }
}
