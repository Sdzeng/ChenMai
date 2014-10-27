using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

using ChenMai.Models.Entities;

namespace ChenMai.Models.Mapping
{
    public class UserModelMap:EntityTypeConfiguration<UserModel>
    {
        public UserModelMap()
        {
            this.ToTable("User");
        }
    }
}
