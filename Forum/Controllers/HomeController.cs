using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Forum.Controllers
{
	public class HomeController : Controller
	{
		readonly Context db;
		public HomeController(Context context)
		{
			db = context;
		}
		public IActionResult Index()
		{
			return View(db.Messages.ToList());
		}

		[HttpPost]
		public string Index(Message message)
		{
			db.Messages.Add(message);
			db.SaveChanges();
			return null;
		}

		[HttpGet]
		public IActionResult Buy(int? id)
		{
			if (id == null)
				RedirectToAction("Index");
			ViewBag.PhoneId = id;
			return View();
		}

		[HttpPost]
		public string Buy(Order order)
		{
			//db.Orders.Add(order);
			db.SaveChanges();
			return $"Thanks for shoping with us {order.User}!";
		}
	}
}
