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

            this.Property(p => p.FechaPago)
                .IsRequired();

            this.ToTable("Pago");

            HasRequired(p => p.Inscripcion)
              .WithMany(p => p.Pagos)
              .HasForeignKey(p => p.InscripcionId);

        }
    }
}
