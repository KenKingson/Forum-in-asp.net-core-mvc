using Forum.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Data
{
	public interface IForum
	{
		Models.Forum GetForum(int id);
		IEnumerable<Models.Forum> GetAll();
		IEnumerable<ApplicationUser> GetAllActiveUsers();

		Task Create(Models.Forum forum);
		Task Delete(int forumId);
		Task UpdateForumTitle(int forumId, string newTitle);
		Task UpdateForumDescription(int forumId, string newDescription);
	}
}
