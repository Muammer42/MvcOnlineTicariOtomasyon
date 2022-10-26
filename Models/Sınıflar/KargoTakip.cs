using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class KargoTakip
    {
        public int KargoTakipid { get; set; }
        [StringLength(10)]
        public string TakipKodu { get; set; }
        [StringLength(100)]
        public string Aciklama { get; set; }
      
        public DateTime TarihZaman { get; set; }
    }
}