using Microsoft.AspNetCore.Mvc;
using ToDoListMvcSQL.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoListMvcSQL.Controllers
{
  public class ItemsController : Controller
  {
    private readonly ToDoListContext _db;

    public ItemsController(ToDoListContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Item> model = _db.Items.ToList();
      return View(model);
    }
  }
}