using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

using ChenMai.Models.Entities;
using ChenMai.Models.Mapping;

namespace ChenMai.Models
{
    public class BaseContext:DbContext
    {
        public BaseContext(): base("DefaultConnection")
        { }

        public DbSet<PlantModel> Plants { get; set; }

        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PlantModelMap());
            modelBuilder.Configurations.Add(new UserModelMap());
        }
    }
}
