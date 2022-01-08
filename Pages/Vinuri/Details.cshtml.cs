using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Colectia_mea_de_vin.Data;
using Colectia_mea_de_vin.Models;

namespace Colectia_mea_de_vin.Pages.Vinuri
{
    public class DetailsModel : PageModel
    {
        private readonly Colectia_mea_de_vin.Data.Colectia_mea_de_vinContext _context;

        public DetailsModel(Colectia_mea_de_vin.Data.Colectia_mea_de_vinContext context)
        {
            _context = context;
        }

        public Vin Vin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vin = await _context.Vin.FirstOrDefaultAsync(m => m.ID == id);

            if (Vin == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
