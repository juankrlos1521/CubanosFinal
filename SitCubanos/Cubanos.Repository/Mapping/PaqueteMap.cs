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
    public class PaqueteMap:EntityTypeConfiguration<Paquete>
    {
        public PaqueteMap() 
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Nombre).HasMaxLength(200).IsRequired();
            this.Property(p => p.Precio).HasPrecision(8, 2).IsRequired();
            this.Property(p => p.FechaRegistro).IsRequired();
            this.Property(p => p.FechaVencimiento).IsRequired();
            this.Property(p => p.Stock).IsRequired();

            this.ToTable("Paquete");
        }
    }
}
