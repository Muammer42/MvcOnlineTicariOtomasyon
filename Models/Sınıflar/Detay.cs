using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Detay
    {
        [Key]
        public int DetayID { get; set; }
       
       
        public string urunad { get; set; }

      
        public string urunbilgi { get; set; }
    }
}