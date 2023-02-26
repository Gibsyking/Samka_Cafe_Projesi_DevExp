using SamkaCafe.Entitiy.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Models
{
    // [Table("Satislar")]
    public class Satislar : IEntity
    {
        public int Id { get; set; }
        public string SatisKodu { get; set; }

        public int MusteriId { get; set; }
        public decimal Tutar { get; set; }
        public decimal indirim { get; set; }
        public decimal Odenen { get; set; }
        public decimal Kalan { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime SonIslemTarihi { get; set; }

        public virtual Musteriler Musteriler { get; set; }
        

    }
}
