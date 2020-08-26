using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Data.Models
{
	public class Forum
	{
		public int Id { get; set; }
		public string Caption { get; set; }
		public DateTime CreationDate { get; set; }
		public virtual IEnumerable<Topic> Topics { get; set; }
		public User Creator { get; set; }
		public string Description { get; set; }
		public int Counter
		{
			get => Topics.Count();
			set { Counter = value; }
		}
	}
}
