using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Colectia_mea_de_vin.Data;
using Colectia_mea_de_vin.Models;

namespace Colectia_mea_de_vin.Pages.Categorii
{
    public class IndexModel : PageModel
    {
        private readonly Colectia_mea_de_vin.Data.Colectia_mea_de_vinContext _context;

        public IndexModel(Colectia_mea_de_vin.Data.Colectia_mea_de_vinContext context)
        {
            _context = context;
        }

        public IList<Categorie> Categorie { get;set; }

        public async Task OnGetAsync()
        {
            Categorie = await _context.Categorie.ToListAsync();
        }
    }
}
