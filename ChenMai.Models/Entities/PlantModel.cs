using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChenMai.Models.Entities
{
    public class PlantModel
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public ICollection<OriginModel> Origins { get; set; }

        public string Remark { get; set; }

        //public string PlantFamilies { get; set; }


        public UserModel CreateUser { get; set; }

        public DateTime CreateDate { get; set; }

        public UserModel ModifyUser { get; set; }

        public Nullable<DateTime> ModifyDate { get; set; }

      

    }
}
