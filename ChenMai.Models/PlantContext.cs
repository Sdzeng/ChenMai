using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ChenMai.Models
{
    public class PlantContext : DbContext
    {
        public PlantContext(): base("DefaultConnection")
        { }
        public DbSet<PlantModel> Plants { get; set; }
    }
}

