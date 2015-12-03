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
    public class CargoMap:EntityTypeConfiguration<Cargo>
    {
        public CargoMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.ToTable("Cargo");
        }
    }
}
