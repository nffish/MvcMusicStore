using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            return View();
        }

        // GET : Albums/List
        public ActionResult List()
        {
            var albums = new List<Album>();
            for (int i =0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Product " + i });
            }
            return View(albums);
        }

        //GET: Albums/Edit?id=5
        public ActionResult Edit(int id = 0)
        {
            Album album = null;
            if(album == null)
            {
                return HttpNotFound();
            }
            //ViewBag.GenreId = new SelectList();
            return View();
        }
    }
}