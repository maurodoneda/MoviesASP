using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace moviesASP.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public double? ReviewScore { get; set; }
    }
}