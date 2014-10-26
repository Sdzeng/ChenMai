using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using ChenMai.Models.Entities;

namespace ChenMai.Models.Mapping
{
    public class PlantModelMap:EntityTypeConfiguration<PlantModel>
    {
        public PlantModelMap()
        {
            this.ToTable("Plant");
            this.Property(model => model.UserID).HasMaxLength(100);
            this.Property(model => model.Name).IsRequired().HasMaxLength(300);
          
            this.Property(model => model.Remark).HasMaxLength(2000);

            this.HasRequired(model => model.User).WithMany(model => model.Plants).HasForeignKey(model=>model.PlantModelD).WillCascadeOnDelete(false);
        }
    }
}
