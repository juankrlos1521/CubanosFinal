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
    public class SeguimientoMap:EntityTypeConfiguration<Seguimiento>
    {
        public SeguimientoMap() 
        {
            this.HasKey(p => p.Id);

            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(s => s.Fecha).IsRequired();
            this.Property(s => s.Peso).HasPrecision(8, 2).IsOptional();
            this.Property(s => s.Altura).HasPrecision(8, 2).IsOptional();
            this.Property(s => s.Brazo).HasPrecision(8, 2).IsOptional();
            this.Property(s => s.Pierna).HasPrecision(8, 2).IsOptional();
            this.Property(s => s.Cintura).HasPrecision(8, 2).IsOptional();
            this.Property(s => s.Abdomen).HasPrecision(8, 2).IsOptional();
            this.Property(s => s.Pecho).HasPrecision(8, 2).IsOptional();
            this.Property(s => s.Observaciones).HasMaxLength(300).IsOptional();

            //this.HasRequired(s => s.Cliente).WithMany(s => s.Seguimiento).HasForeignKey(s => s.ClienteId).WillCascadeOnDelete(false);
            //this.HasRequired(s => s.Empleado).WithMany().HasForeignKey(s => s.IdEmpleado).WillCascadeOnDelete(false);

            this.ToTable("Seguimiento");
        }
    }
}
