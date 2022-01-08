using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Colectia_mea_de_vin.Models;

namespace Colectia_mea_de_vin.Data
{
    public class Colectia_mea_de_vinContext : DbContext
    {
        public Colectia_mea_de_vinContext (DbContextOptions<Colectia_mea_de_vinContext> options)
            : base(options)
        {
        }

        public DbSet<Colectia_mea_de_vin.Models.Vin> Vin { get; set; }

        public DbSet<Colectia_mea_de_vin.Models.Categorie> Categorie { get; set; }
    }
}
