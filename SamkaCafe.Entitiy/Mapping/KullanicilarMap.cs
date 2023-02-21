using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Mapping
{
    public class KullanicilarMap: EntityTypeConfiguration<Kullanicilar>
    {
        public KullanicilarMap()
        {
            this.ToTable("Kullanicilar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Adres).HasColumnType("varchar").HasMaxLength(500);
            this.Property(p => p.AdSoyad).HasColumnType("varchar").HasMaxLength(100);
            this.Property(p => p.Telefon1).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Telefon2).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Email).HasColumnType("varchar").HasMaxLength(150);
            this.Property(p => p.Gorevı).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.KullaniciAdi).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Parola).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Cevap).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);
        }
    }
}
