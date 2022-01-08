using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Colectia_mea_de_vin.Data;
using Colectia_mea_de_vin.Models;

namespace Colectia_mea_de_vin.Pages.Categorii
{
    public class CreateModel : PageModel
    {
        private readonly Colectia_mea_de_vin.Data.Colectia_mea_de_vinContext _context;

        public CreateModel(Colectia_mea_de_vin.Data.Colectia_mea_de_vinContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Categorie Categorie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Categorie.Add(Categorie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
