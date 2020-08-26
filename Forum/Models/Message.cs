using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
	public class Message
	{
		private Guid userId;
		private string text;
		private DateTime creatingDate;
		public Message(Guid userId, string text)
		{
			this.userId = userId;
			this.text = text;
			creatingDate = DateTime.Now;
		}
	}
}
