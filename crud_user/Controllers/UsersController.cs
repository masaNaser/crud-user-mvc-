using Azure.Core;
using crud_user.Data;
using crud_user.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_user.Controllers
{
    public class UsersController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            List<User> users = context.Users.ToList();
            return View("Index",users);
        }
        public IActionResult Create()
        {
            return View("Create");
        }

        public IActionResult Store(User requset) {
         
            context.Users.Add(requset);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            User user = context.Users.Find(id);
            return View("Edit", user);
        }
        public IActionResult Update(User requset)
        {
            User user = context.Users.Find(requset.Id);
            user.Name = requset.Name;
            user.Email = requset.Email;
            user.Score = requset.Score;
            context.Users.Update(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            User user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
