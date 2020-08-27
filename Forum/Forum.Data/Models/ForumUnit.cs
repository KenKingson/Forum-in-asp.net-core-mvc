using System;

namespace Forum.Data.Models
{
	public abstract class ForumUnit
	{
		public int Id { get; set; }
		public string Caption { get; set; }
		public DateTime CreationDate { get; set; }
		public ApplicationUser Creator { get; set; }
	}
}
