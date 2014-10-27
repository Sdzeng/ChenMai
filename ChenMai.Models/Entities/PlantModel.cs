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

        public string Origin { get; set; }

        public string Remark { get; set; }


        public string CreateUser{get; set; }

        public virtual UserModel User { get; set; }

        public DateTime CreateDate { get; set; }

        public string ModifyUser { get; set; }

        public Nullable<DateTime> ModifyDate { get; set; }

    }
}
