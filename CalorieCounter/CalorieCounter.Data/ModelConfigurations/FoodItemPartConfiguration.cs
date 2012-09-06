using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CalorieCounter.Data.Entities;

namespace CalorieCounter.Data.ModelConfigurations
{
	public class FoodItemPartConfiguration : EntityTypeConfiguration<FoodItemPart>
	{
		public FoodItemPartConfiguration()
		{
			Property(fip => fip.Serving).HasPrecision(3, 1);
		}
	}
}
