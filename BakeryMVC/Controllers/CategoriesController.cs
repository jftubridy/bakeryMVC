using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryMVC.Models;

namespace BakeryMVC.Controllers
{
     public class CategoriesController : Controller
  {

    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Category> allVendors = Category.GetAll();
      return View(allVendors);
    }

    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/categories")]
    public ActionResult Create(string vendorName)
    {
      Category newVendor = new Category(vendorName);
      return RedirectToAction("Index");
    }

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category selectedVendor = Category.Find(id);
      List<Item> vendorItems = selectedVendor.Items;
      model.Add("vendor", selectedVendor);
      model.Add("items", vendorItems);
      return View(model);
    }

    // This one creates new Items within a given Category of Vendor, not new Categories:
    [HttpPost("/categories/{vendorId}/items")]
    public ActionResult Create(int vendorId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundVendor = Category.Find(vendorId);
      Item newItem = new Item(itemDescription);
      foundVendor.AddItem(newItem);
      List<Item> vendorItems = foundVendor.Items;
      model.Add("items", vendorItems);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  }
}