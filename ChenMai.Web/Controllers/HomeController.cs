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

            UserModel userModel = new UserModel { UserModelID = "admin", UserName = "管理员", RealName = "song", Password = "123" };

            PlantModel plantModel = new PlantModel
            {
                PlantModelD = "001",
                Name = "猴面包树",
                Origin = "非洲",
                Remark = "test",
                User=userModel,
                CreateDate = DateTime.Now
            };
            BaseContext context = new BaseContext();　　　　//插入一行值
            context.Users.Add(userModel);
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
