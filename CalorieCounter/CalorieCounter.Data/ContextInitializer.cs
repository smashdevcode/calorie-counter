using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCounter.Data.Entities;

namespace CalorieCounter.Data
{
	internal class ContextInitializer : 
		DropCreateDatabaseIfModelChanges<Context>
	{
		protected override void Seed(Context context)
		{
			new List<User>()
			{
				new User()
				{
					Username = "jsmith",
					HashedPassword = "temp",
					Email = "john@smith.com",
					Name = "John Smith"					
				},
				new User()
				{
					Username = "ssmith",
					HashedPassword = "temp",
					Email = "sally@smith.com",
					Name = "Sally Smith"					
				}
			}.ForEach(u => context.Users.Add(u));

			base.Seed(context);
		}
	}
}
