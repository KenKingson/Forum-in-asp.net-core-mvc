using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
	public class Context : DbContext
	{
		public DbSet<Message> Messages { get; set; }
		public DbSet<User> Users { get; set; }
		public Context(DbContextOptions<Context> options) : base(options)
		{
			Database.EnsureCreated();
		}
	}
}
