using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Data.Models
{
	public class Topic
	{
		public int Id { get; set; }
		public string Caption { get; set; }
		public DateTime CreationDate { get; set; }
		public virtual IEnumerable<Post> Posts { get; set; }
		public virtual IdentityUser Creator { get; set; }
		public string Description { get; set; }
		public int Counter
		{
			get => Posts.Count();
			set { Counter = value; }
		}
	}
}
