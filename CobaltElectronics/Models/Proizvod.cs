using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CobaltElectronics.Models
{
    public class Proizvod
    {
        [Required]
        public int Id { get; set; }
        public string Ime { get; set; }
        public float Cena { get; set; }
        public List<Prodavnica> prodavnici {get;set;}

        public Proizvod()
        {
            prodavnici = new List<Prodavnica>();
        }


    }
}