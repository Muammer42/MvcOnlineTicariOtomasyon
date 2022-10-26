﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Faturalar
    {
        [Key]
        public int FaturaID { get; set; }
        public String FaturaSeriNo { get; set; }
        public string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }
        public string VergiDairesi { get; set; }
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string Saat { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }
        public decimal Toplam { get; set; }
        public ICollection<FaturaKalem>FaturaKalems { get; set; }
    
    }
}