using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MondayMvcTest.Models;

namespace MondayMvcTest.Controllers
{
    public class MoviedetailController : Controller
    {
        private readonly ApplicationDbContext _context = null;

        public MoviedetailController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Moviedetail
        public ActionResult Index()
        {
            var moviedatail = _context.Moviedetails.ToList();
            return View(moviedatail);
        }
           
        public ActionResult Create()
        {
            
            return View();
        }
       [HttpPost]
        public ActionResult Create(Moviedetail moviedetail)
        {
            if(ModelState.IsValid)
            {
                _context.Moviedetails.Add(moviedetail);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}