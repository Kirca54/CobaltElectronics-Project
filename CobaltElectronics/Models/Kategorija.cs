using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CobaltElectronics.Models
{
    public class Kategorija
    {
        [Required]
        public int Id { get; set; }
        public string Ime { get; set; }
        public List<Proizvod> proizvodi { get; set; }
        public Kategorija()
        {
            proizvodi=new List<Proizvod>();
        }


    }
}