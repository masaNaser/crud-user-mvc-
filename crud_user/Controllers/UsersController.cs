using Azure.Core;
using crud_user.Data;
using crud_user.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_user.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ActionResult Index()
        {
            List<User> users = context.Users.ToList();
            return View("Index",users);
        }
        public ActionResult Create()
        {
            return View("Create");
        }

        public ActionResult Store(User requset) {
            if (!ModelState.IsValid)
            {
                return View("Create", requset);
            }
            context.Users.Add(requset);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            User user = context.Users.Find(id);
            return View("Edit", user);
        }
        public ActionResult Update(User requset)
        {
            User user = context.Users.Find(requset.Id);
            user.Name = requset.Name;
            user.City = requset.City;
            context.Users.Update(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {            
                User user = context.Users.Find(id);
                context.Users.Remove(user);
                context.SaveChanges();
                return RedirectToAction("Index");
        }

    }
}
