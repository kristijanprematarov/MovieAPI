namespace Movie.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class MovieEntity
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        public string PosterLink { get; set; }
    }
}
