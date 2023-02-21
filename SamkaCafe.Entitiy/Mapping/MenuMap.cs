using System.Data.Entity.ModelConfiguration;
using SamkaCafe.Entitiy.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamkaCafe.Entitiy.Mapping
{
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        public MenuMap() 
        {
            this.ToTable("Menu");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MenuAdi).HasColumnType("varchar").HasMaxLength(60);
            this.Property(p => p.Aciklama).HasColumnType("varchar").HasMaxLength(300);
           // İSİM DEĞİŞTİRME  this.Property(p => p.Aciklama).HasColumnName("Description");
        }
    }
}
