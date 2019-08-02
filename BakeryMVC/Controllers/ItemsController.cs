using Microsoft.AspNetCore.Mvc;
using BakeryMVC.Models;
using System.Collections.Generic;

namespace BakeryMVC.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/categories/{vendorId}/items/new")]
    public ActionResult New(int vendorId)
    {
       Category vendor = Category.Find(vendorId);
       return View(vendor);
    }

    [HttpGet("/categories/{vendorId}/items/{itemId}")]
    public ActionResult Show(int vendorId, int itemId)
    {
      Item item = Item.Find(itemId);
      Category vendor = Category.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("item", item);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

  }
}