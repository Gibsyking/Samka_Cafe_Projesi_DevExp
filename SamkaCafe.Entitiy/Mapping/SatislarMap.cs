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
    public class SatislarMap: EntityTypeConfiguration<Satislar>
    {
        public SatislarMap()
        {
            this.ToTable("Satislar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SatisKodu).HasColumnType("varchar").HasMaxLength(15);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);

            //this.HasOptional(m => m.Musteriler).WithMany(m => m.Satislar).HasForeignKey(m => m.MusteriId);
            //this.HasRequired(x => x.Musteriler).WithMany(x => x.Satislar).HasForeignKey(x => x.MusteriId);
        }
    }
}
