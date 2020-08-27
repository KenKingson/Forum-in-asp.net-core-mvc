namespace Forum.Data.Models
{
	public class PostReply : ForumUnit
	{
		public string Content { get; set; }
		public virtual Post Post { get; set; }
	}
}