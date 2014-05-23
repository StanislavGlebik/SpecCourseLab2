using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpecCourse_Lab2WithAuth.Models;
using System.Web.Configuration;
using Newtonsoft.Json;

namespace SpecCourse_Lab2WithAuth.Controllers
{
    public class BookController : Controller
    {
        private LibraryDbContext db = new LibraryDbContext();

        //
        // GET: /Book/

        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        public ActionResult JsonBooksList()
        {
            return Content(JsonConvert.SerializeObject(db.Books.ToList()));
        }

        //
        // GET: /Book/Details/5

        public ActionResult Details(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        public ActionResult JsonBookDetails(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return Content(JsonConvert.SerializeObject(book));
        }

        //
        // Get: /Book/Content/5

        public ActionResult Content(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            try
            {
                BasicHttpBinding_ILibraryWCFService contentProvider = new BasicHttpBinding_ILibraryWCFService();
                string clientId = WebConfigurationManager.AppSettings["clientId"];
                string productId = WebConfigurationManager.AppSettings["productId"];
                ViewBag.Content = contentProvider.GetBookContent((int)book.BookCode,
                                                                true,
                                                                clientId);
            }
            catch (Exception)
            {
                ViewBag.Content = "Cannot connect to content provider!";
            }
            return View();
        }

        public ActionResult SimpleContent(int id = 0)
        {
            Book book = db.Books.Find(id);
            String content;
            if (book == null)
            {
                return HttpNotFound();
            }
            try
            {
                BasicHttpBinding_ILibraryWCFService contentProvider = new BasicHttpBinding_ILibraryWCFService();
                string clientId = WebConfigurationManager.AppSettings["clientId"];
                string productId = WebConfigurationManager.AppSettings["productId"];
                content = contentProvider.GetBookContent((int)book.BookCode,
                                                                true,
                                                                clientId);
            }
            catch (Exception)
            {
                content = "Cannot connect to content provider!";
            }
            return Content(content);
        }

        //
        // GET: /Book/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.Authors = db.Authors.ToList();
            return View();
        }

        //
        // POST: /Book/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(Book book, List<int> authorsId)
        {
            if (ModelState.IsValid)
            {
                var authors = from r in db.Authors
                               from id in authorsId
                               where r.Id == id
                               select r;
                book.Authors = authors.ToList();

                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }

        //
        // GET: /Book/Edit/5
        [Authorize]
        public ActionResult Edit(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.Authors = db.Authors.ToList();
            return View(book);
        }

        //
        // POST: /Book/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(Book book, List<int> authorsId)
        {
            if (ModelState.IsValid)
            {
                var authors = from r in db.Authors
                              from id in authorsId
                              where r.Id == id
                              select r;
                var bookInDb = db.Books.Find(book.Id);

                bookInDb.Authors.Clear();
                bookInDb.BookCode = book.BookCode;
                bookInDb.Title = book.Title;
                bookInDb.PublishingDate = book.PublishingDate;
                try
                {
                    foreach (var author in authors.ToList())
                    {
                        bookInDb.Authors.Add(author);
                    }
                }
                catch (Exception e)
                {}

                db.Entry(bookInDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        [HttpPost]
        [Authorize]
        public ActionResult EditTitle(int id, string value)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            book.Title = value;
            db.SaveChanges();
            return Content(value);
        }

        [HttpPost]
        [Authorize]
        public ActionResult EditDate(int id, string value)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            book.PublishingDate = DateTime.Parse(value);
            db.SaveChanges();
            return Content(value);
        }


        //
        // GET: /Book/Delete/5
        [Authorize]
        public ActionResult Delete(int id = 0)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
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