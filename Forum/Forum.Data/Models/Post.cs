using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Data.Models
{
	public class Post
	{
		public int Id { get; set; }
		public string Caption { get; set; }
		public DateTime CreationDate { get; set; }
		public User Creator { get; set; }
	}
}
