using Microsoft.AspNetCore.Mvc;
using ToDoListMvcSql.Models;
using System.Collections.Generic;

namespace ToDoListMvcSql.Controllers
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