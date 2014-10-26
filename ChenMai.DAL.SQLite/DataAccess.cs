using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChenMai.IDAL;
using ChenMai.IDAL.Basic;

using ChenMai.DAL.SQLite.Basic;

namespace ChenMai.DAL.SQLite
{
    public class DataAccess : IDataAccess
    {
        private IPlantDAL plantDAL = null;
        /// <summary>
        /// 植物
        /// </summary>
        public IPlantDAL PlantDAL
        {
            get
            {
                if (this.plantDAL == null) this.plantDAL = new PlantDAL();
                return this.plantDAL;
            }
        }

    }
}
