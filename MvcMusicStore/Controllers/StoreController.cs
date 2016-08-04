using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public String Index()
        {
            return "Hello from Store.Index()";
        }

        // GET: /Store/Browse
        //public String Browse()
        //{
        //    return "Hello from Store.Browse()";
        //}

        // GET: /Store/Browse?genre=?Disco
        public String Browse(String genre)
        {
            String message;
            if (genre == null)
            {
                message = "";
            }
            else
            {
                message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            }
            
            return message;
        }

        // GET : Store/Details
        public String Details(int id)
        {
            string message = "Store.details, ID = " + id;
            return message;
        }
    }
}