using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChenMai.Models.Entities
{
    public class UserModel
    {
        public string ID { get; set; }
     
        public string Password { get; set; }

        public string UserName { get; set; }

        public string RealName { get; set; }

        public virtual ICollection<PlantModel> CreatePlants { get; set; }

        public virtual ICollection<PlantModel> ModifyPlants { get; set; }

    }
}
