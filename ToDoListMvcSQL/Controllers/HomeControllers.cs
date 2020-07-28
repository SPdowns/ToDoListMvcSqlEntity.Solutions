using Microsoft.AspNetCore.Mvc;
using ToDoListMvcSQL.Models;
using System.Collections.Generic;

namespace ToDoListMvcSQL.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}