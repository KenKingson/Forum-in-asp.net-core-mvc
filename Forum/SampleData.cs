using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum
{
	public static class SampleData
	{
		public static void Initialize(Context context)
		{
			if (!context.Messages.Any())
			{
				context.Messages.AddRange(
				   new Message
				   {
					   Text = "Hello world"
				   }
			   );
                context.SaveChanges();
            }
		}
	}
}
