using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
	public class User
	{
		public int UserId { get; set; }
		private DateTime DateOfCreating { get; set; }

		public User()
		{
			this.DateOfCreating = DateTime.Now;
		}
	}
}
