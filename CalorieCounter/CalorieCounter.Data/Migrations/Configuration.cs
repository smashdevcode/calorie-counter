namespace CalorieCounter.Data.Migrations
{
	using CalorieCounter.Data.Entities;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context context)
        {
			context.Users.AddOrUpdate(
				u => u.Email,
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
			);

			// JCTODO seed additional data
        }
    }
}
