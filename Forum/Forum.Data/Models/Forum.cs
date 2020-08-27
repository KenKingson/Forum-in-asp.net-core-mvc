using System.Collections.Generic;
using System.Linq;

namespace Forum.Data.Models
{
	public class Forum : ForumUnit
	{
		public virtual IEnumerable<Post> Posts { get; set; }
		public string Description { get; set; }
		public int Counter
		{
			get => Posts.Count();
			set { Counter = value; }
		}
	}
}
