using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Colectia_mea_de_vin.Models
{
    public class Vin
    {
        public int ID { get; set; }
        [Display(Name = "Denumire")]
        public string Nume { get; set; }
        public string Producator { get; set; }
        public string Regiune { get; set; }
        public string Tip { get; set; }
        public string An { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataCumpararii { get; set; }
        public ICollection<CategorieVin> CategoriiVin { get; set; }

    }
}
