namespace ChenMai.Models.Migrations
{
    using ChenMai.Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ChenMai.Models.BaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());    // This will add our MySQLClient as SQL Generator  
        }

        /// <summary>
        /// InitialCreateִ�к󣬲Ż����Seed�����������������һЩ��������
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ChenMai.Models.BaseContext context)
        {
            context.Plants.AddOrUpdate(model => model.ID,
                new PlantModel {  ID="001",
                                                    Name="�����", 
                                                    Origins=new List<OriginModel>{
                                                                                                            new OriginModel{ ID="001",Name="�й�"},
                                                                                                            new OriginModel{ ID="002",Name="���"}
                                                    },
                                                    //Remark="", 
                                                    CreateUser=new UserModel{ ID="001", RealName="Song", UserName="Song", Password="123"},
                                                    CreateDate=DateTime.Now}
                 );
        }
    }
}
