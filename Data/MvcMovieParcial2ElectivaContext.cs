#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieParcial2Electiva.Models;

namespace MvcMovieParcial2Electiva.Data
{
    public class MvcMovieParcial2ElectivaContext : DbContext
    {
        public MvcMovieParcial2ElectivaContext (DbContextOptions<MvcMovieParcial2ElectivaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieParcial2Electiva.Models.Movie> Movie { get; set; }
    }
}
