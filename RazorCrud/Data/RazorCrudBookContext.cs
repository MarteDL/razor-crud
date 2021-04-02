using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorCrud.Models;

    public class RazorCrudBookContext : DbContext
    {
        public RazorCrudBookContext (DbContextOptions<RazorCrudBookContext> options)
            : base(options)
        {
        }

        public DbSet<RazorCrud.Models.Book> Book { get; set; }
    }
