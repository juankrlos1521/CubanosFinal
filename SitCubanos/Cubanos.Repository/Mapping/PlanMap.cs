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
    public class PlanMap:EntityTypeConfiguration<Plan>
    {
        public PlanMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Descripcion).HasMaxLength(500).IsRequired();
            this.Property(p => p.FechaInicio).IsRequired();
            this.Property(p => p.FechaFin).IsRequired();
            this.HasRequired(p => p.Cliente).WithMany(c => c.Planes).HasForeignKey(p => p.ClienteId).WillCascadeOnDelete(true);
            this.ToTable("Plan");
        }
    }
}
