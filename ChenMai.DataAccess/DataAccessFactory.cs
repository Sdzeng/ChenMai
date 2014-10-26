using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChenMai.IDAL;

namespace ChenMai.DataAccess
{
    public class DataAccessFactory
    {

        /// <summary>
        /// 创建数据访问对象
        /// </summary>
        /// <param name="log">日志对象</param>
        /// <param name="connection">连接信息</param>
        /// <returns></returns>
        public static IDataAccess Create(string dataAccessType)
        {
            dataAccessType = dataAccessType.ToLower();

            IDataAccess dataAccess = null;
            switch(dataAccessType){
               case "mysql": dataAccess = new ChenMai.DAL.MySQL.DataAccess();break;
               case "oracle": dataAccess = new ChenMai.DAL.Oracle.DataAccess();break;
               case "sqlite": dataAccess = new ChenMai.DAL.SQLite.DataAccess();break;
            }

            return dataAccess;
        }
    }
}
