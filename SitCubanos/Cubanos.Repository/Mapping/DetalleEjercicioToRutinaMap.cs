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
    public class DetalleEjercicioToRutinaMap:EntityTypeConfiguration<DetalleEjercicioToRutina>
    {
        public DetalleEjercicioToRutinaMap() 
        {
            this.HasKey(cp => new { cp.RutinaId, cp.EjercicioId });

            //propiedades

            Property(cp => cp.EjercicioId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(cp => cp.RutinaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(cp => cp.NroOrden).IsRequired();
            Property(cp => cp.NroSeries).IsRequired();
            Property(cp => cp.NroRepeticiones).IsRequired();

            HasRequired(cp => cp.Ejercicio)
               .WithMany(cp => cp.DetalleEjercicioToRutina)
               .HasForeignKey(cp => cp.EjercicioId);

            HasRequired(cp => cp.Rutina)
                .WithMany(cp => cp.DetalleEjercicioToRutina)
                .HasForeignKey(cp => cp.RutinaId);

            this.ToTable("DetalleEjercicioToRutina");
        }
    }
}
