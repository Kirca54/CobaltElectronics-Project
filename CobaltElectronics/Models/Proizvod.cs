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
        [Display(Name ="Слика")]
        public string ImgURL { get; set; }
        [Display(Name = "Име")]
        public string Ime { get; set; }
        [Display(Name = "Производител")]
        public string Proizvoditel { get; set; }
        [Display(Name = "Цена")]
        public float Cena { get; set; }
        [Display(Name = "Залиха")]
        public bool DaliNaZaliha { get; set; }
        public List<Prodavnica> prodavnici {get;set;}

        public Proizvod()
        {
            prodavnici = new List<Prodavnica>();
        }


    }
}