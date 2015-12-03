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
    class AsistenciaMap:EntityTypeConfiguration<Asistencia>
    {
        public  AsistenciaMap()
        {
            this.HasKey(a => a.Id);

            this.Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(a => a.Fecha)
                .IsRequired();
            this.Property(a => a.Estado)
                .HasColumnType("bit")
                .IsRequired();

            this.ToTable("Asistencia");

            HasRequired(cp => cp.Inscripcion)
               .WithMany(cp => cp.Asistencia)
               .HasForeignKey(cp => cp.InscripcionId);

            //HasRequired(cp => cp.Curso)
            //   .WithMany(cp => cp.Asistencia)
            //   .HasForeignKey(cp => cp.CursoId);
        }
    }
}
