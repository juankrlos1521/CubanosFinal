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
    public class EjercicioMap:EntityTypeConfiguration<Ejercicio>
    {
        public EjercicioMap() 
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.Nombre).HasMaxLength(150).IsRequired();
            this.Property(e => e.Descripcion).HasMaxLength(300).IsRequired();
            this.ToTable("Ejercicio");
        }
    }
}
