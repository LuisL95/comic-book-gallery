using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController() 
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index() 
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }
        public ActionResult Detail( int ? id)
        {
            if (id == null) 
            {
               return HttpNotFound();
            }
            var comicBook = _comicBookRepository.getComicBook((int)id);

        

            //if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            //{
            //    return Redirect("/");
            //}
            //return new ContentResult()
            //{
            //    Content = "hello world this is my first controllator"
            //};

           //ViewBag.SeriesTitle = "The Amazing Spider-Man";

           // ViewBag.IssueNumber = 700;

           // ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, " +
           //             "last, great act of revenge! Even if Spider-Man survives..." +
           //             " <strong>will Peter Parker?</strong></p>";
            //ViewBag.Artists = new String[]
            //{
            //    "Script: Dan Slott",
            //    "Pencils: Humberto Ramos",
            //    "Inks: Victor Olazaba",
            //    "Colors: Edgar Delgado",
            //    "Letters: Chris Eliopoulos"
            //};

            return View(comicBook);
        }
    }
}