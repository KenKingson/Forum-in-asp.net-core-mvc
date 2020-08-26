﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
	public class Message
	{
		public int Id { get; set; }
		public string UserId { get; set; }
		public string Text { get; set; }
		public DateTime CreatingDate { get; set; }
		public Message()
		{
			CreatingDate = DateTime.Now;
		}
	}
}