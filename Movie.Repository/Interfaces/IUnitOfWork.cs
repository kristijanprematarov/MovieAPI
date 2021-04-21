using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository Movies { get; }
        int Complete();
    }
}
