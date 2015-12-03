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
    public class EmpleadoMap:EntityTypeConfiguration<Empleado>
    {
        public EmpleadoMap() 
        {

            this.HasKey(p => p.Id);

            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Dni).HasMaxLength(8).IsRequired();
            this.Property(p => p.ApellidoPaterno).HasMaxLength(200).IsRequired();
            this.Property(p => p.ApellidoMaterno).HasMaxLength(200).IsRequired();
            this.Property(p => p.Nombres).HasMaxLength(200).IsRequired();
            this.Property(p => p.FechaNacimiento).IsRequired();
            this.Property(p => p.Direccion).HasMaxLength(200).IsRequired();
            this.Property(p => p.Telefono).HasMaxLength(200).IsRequired();
            this.Property(p => p.Email).HasMaxLength(200).IsRequired();
            this.Property(p => p.Sexo).HasColumnType("bit").IsRequired();
            this.Property(p => p.Estado).HasColumnType("bit").IsRequired();
            this.Property(e => e.FechaIngreso).IsRequired();
            this.Property(e => e.Salario).HasPrecision(8, 2).IsRequired();
            this.HasRequired(e => e.Cargo).WithMany(c => c.Empleados).HasForeignKey(e => e.CargoId).WillCascadeOnDelete(false);

            this.ToTable("Empleado");
            
        }
    }
}
