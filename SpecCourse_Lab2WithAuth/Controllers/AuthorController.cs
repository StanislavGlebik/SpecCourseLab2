using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpecCourse_Lab2WithAuth.Models;
using Newtonsoft.Json;

namespace SpecCourse_Lab2WithAuth.Controllers
{
    public class AuthorController : Controller
    {
        private LibraryDbContext db = new LibraryDbContext();

        //
        // GET: /Author/

        public ActionResult Index()
        {
            return View(db.Authors.ToList());
        }

        public ActionResult JsonAuthorsList()
        {
            return Content(JsonConvert.SerializeObject(db.Authors.ToList()));
        }

        //
        // GET: /Author/Details/5

        public ActionResult Details(int id = 0)
        {
            Author author = db.Authors.Find(id);
            if (author == null)
            {
                return HttpNotFound();
            }
            return View(author);
        }

        public ActionResult JsonAuthorDetails(int id = 0)
        {
            Author author = db.Authors.Find(id);
            if (author == null)
            {
                return HttpNotFound();
            }
            return Content(JsonConvert.SerializeObject(author));
        }

        //
        // GET: /Author/Create

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Author/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(Author author)
        {
            if (ModelState.IsValid)
            {
                author.Books = new List<Book>();
                db.Authors.Add(author);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(author);
        }

        //
        // POST: /Author/Edit/5

        [HttpPost]
        [Authorize]
        public ActionResult EditName(int id, string value)
        {
            Author author = db.Authors.Find(id);
            if (author == null)
            {
                return HttpNotFound();
            }
            author.Name = value;
            db.SaveChanges();
            return Content(value);
        }

        [HttpPost]
        [Authorize]
        public ActionResult EditDate(int id, string value)
        {
            Author author = db.Authors.Find(id);
            if (author == null)
            {
                return HttpNotFound();
            }
            author.BirthDate = DateTime.Parse(value);
            db.SaveChanges();
            return Content(value);
        }

        //
        // GET: /Author/Delete/5
        [Authorize]
        public ActionResult Delete(int id = 0)
        {
            Author author = db.Authors.Find(id);
            db.Authors.Remove(author);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}