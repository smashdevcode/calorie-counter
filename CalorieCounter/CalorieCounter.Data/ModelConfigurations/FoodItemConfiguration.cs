using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CalorieCounter.Data.Entities;

namespace CalorieCounter.Data.ModelConfigurations
{
	public class FoodItemConfiguration : EntityTypeConfiguration<FoodItem>
	{
		public FoodItemConfiguration()
		{
			Property(fi => fi.Name).HasMaxLength(50).IsRequired();
            Property(fi => fi.ServingSize).HasMaxLength(100);
            //Property(fi => fi.Fat).HasPrecision(3, 1);

			this.HasMany(fi => fi.FoodItemParts)
				.WithRequired(fip => fip.FoodItem)
				.HasForeignKey(fip => fip.FoodItemID);
			this.HasMany(fi => fi.ContainedByFoodItemParts)
				.WithRequired(fip => fip.ContainsFoodItem)
				.HasForeignKey(fip => fip.ContainsFoodItemID)
				.WillCascadeOnDelete(false);
		}
	}
}
