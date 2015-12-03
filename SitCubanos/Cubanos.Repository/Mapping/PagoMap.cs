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
    public class PagoMap:EntityTypeConfiguration<Pago>
    {
        public PagoMap() 
        {
            this.HasKey(p => p.Id);

            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Monto)
                .HasPrecision(9, 2)
                .IsRequired();

            this.Property(p => p.FechaVencimiento)
                .IsOptional();

            this.Property(p => p.FechaPago)                
                .IsOptional();

            this.ToTable("Pago");

            HasRequired(cp => cp.Inscripcion)
               .WithMany(cp => cp.Pago)
               .HasForeignKey(cp => cp.InscripcionId);

        }
    }
}
