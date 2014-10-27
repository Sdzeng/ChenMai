using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

using ChenMai.Models;
using ChenMai.Models.Entities;
using ChenMai.Models.Mapping;

namespace ChenMai.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "song";

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BaseContext>());

            List<OriginModel> originModelList = new List<OriginModel> { new OriginModel { ID = "001", Name = "非洲" } };

            UserModel createUserModel = new UserModel { ID = "admin1", UserName = "管理员", RealName = "song", Password = "123" };

            UserModel modifyUserModel = new UserModel { ID = "admin2", UserName = "管理员", RealName = "song", Password = "123" };

            PlantModel plantModel = new PlantModel
            {
                ID = "003",
                Name = "猴面包树",
                Origins = originModelList,
                Remark = "test",
                CreateUser=createUserModel,
                CreateDate = DateTime.Now,
                ModifyUser=modifyUserModel,
                ModifyDate=DateTime.Now
            };
            BaseContext context = new BaseContext();　　　　//插入一行值
            context.Users.Add(createUserModel);
            context.Users.Add(modifyUserModel);
            context.Plants.Add(plantModel);
      
            context.SaveChanges();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
