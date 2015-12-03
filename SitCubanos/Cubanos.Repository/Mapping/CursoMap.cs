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
    public class CursoMap:EntityTypeConfiguration<Curso>
    {
        public CursoMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Nombre).HasMaxLength(200).IsRequired();            
            this.Property(c => c.FechaInicio).IsOptional();
            this.Property(c => c.FechaFin).IsOptional();            
            this.Property(c => c.Precio).HasPrecision(8,2).IsRequired();
            this.HasMany(p => p.Paquetes).WithMany(c => c.Cursos).Map(t=>t.ToTable("CursoPaquete").MapLeftKey("CursoId").MapRightKey("PaqueteId"));
            this.ToTable("Curso");
        }
    }
}
