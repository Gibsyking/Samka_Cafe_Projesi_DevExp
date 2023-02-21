﻿using SamkaCafe.Entitiy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Mapping
{
    public class RollerMap: EntityTypeConfiguration<Roller>
    {
        public RollerMap()
        {
            this.ToTable("Roller");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.ControlCaption).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.ControlName).HasColumnType("varchar").HasMaxLength(50);
            this.Property(p => p.FormText).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
