using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThiTrang573.Models;

    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenThiTrang573.Models.PersionNTT573> PersionNTT573 { get; set; }

        public DbSet<NguyenThiTrang573.Models.NTT0573> NTT0573 { get; set; }
    }
