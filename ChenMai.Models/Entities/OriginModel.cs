using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChenMai.Models.Entities
{
    public class OriginModel
    {
        public string ID { get;set;}

        public string Name { get; set; }

        public string Remark { get; set; }

        public ICollection<PlantModel> Plants { get; set; }
    }
}
