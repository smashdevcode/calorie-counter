using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalorieCounter.Data.Entities;
using CalorieCounter.Data;

namespace CalorieCounter.Controllers
{
    public class UserController : Controller
    {
        private Repository repository = new Repository(true);

        //
        // GET: /User/

        public ActionResult Index()
        {
            return View(repository.GetUsers());
        }

        //
        // GET: /User/Details/5

		//public ActionResult Details(int id = 0)
		//{
		//	User user = repository.Users.Find(id);
		//	if (user == null)
		//	{
		//		return HttpNotFound();
		//	}
		//	return View(user);
		//}

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /User/Create

		//[HttpPost]
		//public ActionResult Create(User user)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		repository.Users.Add(user);
		//		repository.SaveChanges();
		//		return RedirectToAction("Index");
		//	}

		//	return View(user);
		//}

        //
        // GET: /User/Edit/5

		//public ActionResult Edit(int id = 0)
		//{
		//	User user = repository.Users.Find(id);
		//	if (user == null)
		//	{
		//		return HttpNotFound();
		//	}
		//	return View(user);
		//}

        //
        // POST: /User/Edit/5

		//[HttpPost]
		//public ActionResult Edit(User user)
		//{
		//	if (ModelState.IsValid)
		//	{
		//		repository.Entry(user).State = EntityState.Modified;
		//		repository.SaveChanges();
		//		return RedirectToAction("Index");
		//	}
		//	return View(user);
		//}

        //
        // GET: /User/Delete/5

		//public ActionResult Delete(int id = 0)
		//{
		//	User user = repository.Users.Find(id);
		//	if (user == null)
		//	{
		//		return HttpNotFound();
		//	}
		//	return View(user);
		//}

        //
        // POST: /User/Delete/5

		//[HttpPost, ActionName("Delete")]
		//public ActionResult DeleteConfirmed(int id)
		//{
		//	User user = repository.Users.Find(id);
		//	repository.Users.Remove(user);
		//	repository.SaveChanges();
		//	return RedirectToAction("Index");
		//}

        protected override void Dispose(bool disposing)
        {
            repository.Dispose();
            base.Dispose(disposing);
        }
    }
}