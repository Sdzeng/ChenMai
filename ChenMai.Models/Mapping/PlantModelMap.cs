﻿using System;
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
            this.Property(model => model.ID).HasMaxLength(100);
            this.Property(model => model.Name).IsRequired().HasMaxLength(300);
          
            this.Property(model => model.Remark).HasMaxLength(2000);

            this.HasOptional(model => model.CreateUser).WithMany(model => model.CreatePlants);
            this.HasOptional(model => model.ModifyUser).WithMany(model => model.ModifyPlants);
            //this.HasRequired(model => model.User).WithMany(model => model.Plants).HasForeignKey(model=>model.ID).WillCascadeOnDelete(false);

            this.HasMany(model => model.Origins).WithMany(model => model.Plants).Map(NewTable =>
            {
                NewTable.ToTable("PlantOriginRelations");
                NewTable.MapLeftKey("PlantId");
                NewTable.MapRightKey("OriginId");
            });
        }
    }
}
