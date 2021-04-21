using Movie.Data;
using Movie.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context, IMovieRepository movieRepository)
        {
            _context = context;
            Movies = movieRepository;
        }

        public IMovieRepository Movies { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
