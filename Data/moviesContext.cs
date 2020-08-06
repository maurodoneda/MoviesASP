using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using moviesASP.Models;

namespace moviesASP.Data
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
       
    
        public MoviesContext()
        {
        }

    }
}
