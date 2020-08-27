using System.Collections.Generic;

namespace Forum.Data.Models
{
	public class Post : ForumUnit
	{
		public string Content { get; set; }
		public virtual Forum Forum { get; set; }
		public virtual IEnumerable<PostReply> Replies { get; set; }
	}
}
