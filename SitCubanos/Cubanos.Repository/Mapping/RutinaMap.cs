using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubanos.BusinessEntity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cubanos.Repository.Mapping
{
    public class RutinaMap:EntityTypeConfiguration<Rutina>
    {
        public RutinaMap() 
        {
            this.HasKey(r => r.Id);
            this.Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(r => r.NroOrden).IsRequired();
            this.Property(r => r.Descripcion).HasMaxLength(200).IsRequired();
            this.Property(r => r.Objetivo).HasMaxLength(50).IsOptional();

            HasRequired(r => r.Plan)
                .WithMany(r => r.Rutina)
                .HasForeignKey(r => r.PlanId);
            
            this.ToTable("Rutina");
        }
    }
}
