using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCounter.Data.Entities;
using CalorieCounter.Data.ModelConfigurations;

namespace CalorieCounter.Data
{
	public class Context : DbContext
	{
		public DbSet<DailyTarget> DailyTargets { get; set; }
		public DbSet<FoodItem> FoodItems { get; set; }
		public DbSet<LogEntry> LogEntries { get; set; }
		public DbSet<LogEntryFoodItem> LogEntryFoodItems { get; set; }
		public DbSet<MealType> MealTypes { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<UserWeight> UserWeights { get; set; }

		// TODO remove???
		//public Context()
		//	: base("name=CalorieCounterContext")
		//{
		//}
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			modelBuilder.Configurations.Add(new DailyTargetConfiguration());
			modelBuilder.Configurations.Add(new FoodItemConfiguration());
			modelBuilder.Configurations.Add(new LogEntryConfiguration());
			modelBuilder.Configurations.Add(new LogEntryFoodItemConfiguration());
			modelBuilder.Configurations.Add(new MealTypeConfiguration());
			modelBuilder.Configurations.Add(new UserConfiguration());
			modelBuilder.Configurations.Add(new UserWeightConfiguration());
		}
	}
}
