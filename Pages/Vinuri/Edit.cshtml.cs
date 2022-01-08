using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Colectia_mea_de_vin.Data;
using Colectia_mea_de_vin.Models;

namespace Colectia_mea_de_vin.Pages.Vinuri
{
    public class EditModel : PageModel
    {
        private readonly Colectia_mea_de_vin.Data.Colectia_mea_de_vinContext _context;

        public EditModel(Colectia_mea_de_vin.Data.Colectia_mea_de_vinContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Vin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VinExists(Vin.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VinExists(int id)
        {
            return _context.Vin.Any(e => e.ID == id);
        }
    }
}
