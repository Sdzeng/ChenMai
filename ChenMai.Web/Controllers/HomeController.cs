using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

using ChenMai.Models;
using ChenMai.Models.Entities;
using ChenMai.Models.Mapping;
using ChenMai.Models.ViewModels;

namespace ChenMai.Web.Controllers
{
    public class HomeController : Controller
    {
        BaseContext context = new BaseContext();

        public ActionResult Index(string searchText="")//默认视图没找到表单有传递一个空字符串，但在单元测试里没有传递值，所以给个空字符串以运行测试
        {
            ViewBag.Message = "song";

         //   Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BaseContext>());

         //   List<OriginModel> originModelList = new List<OriginModel> { new OriginModel { ID = "002", Name = "欧洲" } };

         //   UserModel createUserModel = new UserModel { ID = "admin5", UserName = "管理员", RealName = "song", Password = "123" };

         //   UserModel modifyUserModel = new UserModel { ID = "admin3", UserName = "管理员", RealName = "song", Password = "123" };

         //   PlantModel plantModel = new PlantModel
         //   {
         //       ID = "001",
         //       Name = "猴面包树",
         //       Origins = originModelList,
         //       Remark = "test",
         //       CreateUser=createUserModel,
         //       CreateDate = DateTime.Now,
         //       ModifyUser=modifyUserModel,
         //       ModifyDate=DateTime.Now
         //   };
         ////插入一行值
         //   context.Users.Add(createUserModel);
         //   context.Users.Add(modifyUserModel);
         //   context.Plants.Add(plantModel);
      
         //   context.SaveChanges();

            //var plantList = from p in context.Plants
            //                            where p.Name.Contains(searchText)
            //                            orderby p.ID descending
            //                            select new PlantViewModel
            //                            {
            //                                Name = p.Name,
            //                                OriginsCount = p.Origins.Count
            //                            };

            var plantList = context.Plants.Where(p => p.Name.Contains(searchText))
                                        .OrderByDescending(p => p.ID)
                                        .Select(p=>new PlantViewModel{
                                            Name = p.Name,
                                            OriginsCount = p.Origins.Count
                                        });

            return View(plantList);
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

        protected override void Dispose(bool disposing)
        {
            if (context != null)
            {
                context.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
