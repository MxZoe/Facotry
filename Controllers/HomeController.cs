using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;


namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }


      [HttpGet("/")]
      public ActionResult Index()
      {
        
        return View(_db.MachineEngineer);
      }

    }
}