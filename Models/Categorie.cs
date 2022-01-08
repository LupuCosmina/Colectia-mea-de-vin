using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colectia_mea_de_vin.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string NumeCategorie { get; set; }
        public ICollection<CategorieVin> CategoriiVin { get; set; }

    }
}
