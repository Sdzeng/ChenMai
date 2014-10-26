using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChenMai.IDAL.Basic;

namespace ChenMai.IDAL
{
    public interface IDataAccess
    {

        IPlantDAL PlantDAL { get; }
    }
}
