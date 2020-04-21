using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewMoviesAPI.Models;

namespace NewMoviesAPI.Data
{
    public class NewMoviesAPIDbContext : DbContext
    {
        public NewMoviesAPIDbContext (DbContextOptions<NewMoviesAPIDbContext> options)
            : base(options)
        {
        }

        public DbSet<NewMoviesAPI.Models.Movie> Movie { get; set; }
    }
}
