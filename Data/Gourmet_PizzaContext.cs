using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gourmet_Pizza.Model;

namespace Gourmet_Pizza.Data
{
    public class Gourmet_PizzaContext : DbContext
    {
        public Gourmet_PizzaContext (DbContextOptions<Gourmet_PizzaContext> options)
            : base(options)
        {
        }

        public DbSet<Gourmet_Pizza.Model.Pizza> Pizza { get; set; }
    }
}
