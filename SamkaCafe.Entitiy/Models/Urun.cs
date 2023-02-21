﻿using SamkaCafe.Entitiy.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Models
{
    // URUN TABLOSUNU EKLEME SQL İÇERİSİNE
    [Table("Urun")]
    public class Urun : IEntity
    {
        //[Key]
        public int Id { get; set; }

        //  [ForeignKey("Menu")]
        public int MenuId { get; set; }
        //[Column(TypeName = "varchar")]
        // [StringLength(20)]
        public string UrunKodu { get; set; }

        public string UrunAdi { get; set; }

        public decimal BirimFiyati1 { get; set; }

        public decimal BirimFiyati2 { get; set; }

        public decimal BirimFiyati3 { get; set; }

        public string Aciklama { get; set; }

        public DateTime Tarih { get; set; }
        public string Resim { get; set; }
        public Menu Menu { get; set; }



    }
}
