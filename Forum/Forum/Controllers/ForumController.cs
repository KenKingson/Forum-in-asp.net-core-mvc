﻿using Forum.Data;
using Forum.Models.Forum;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Forum.Controllers
{
	public class ForumController : Controller
	{
		private readonly IForum _forumService;
		public ForumController(IForum forumService)
		{
			_forumService = forumService;
		}

		public IActionResult Index()
		{
			var forums = _forumService.GetAll()
				.Select(forum => new ForumListingModel
				{
					Id = forum.Id,
					Name = forum.Caption,
					Description = forum.Description
				});

			var model = new ForumIndexModel
			{
				ForumList = forums
			};
			return View(model);
		}
	}
}
