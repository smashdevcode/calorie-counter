using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CalorieCounter.Data.Entities;

namespace CalorieCounter.Data.ModelConfigurations
{
	public class DailyTargetConfiguration : EntityTypeConfiguration<DailyTarget>
	{
		public DailyTargetConfiguration()
		{
			Property(dt => dt.Fat).HasPrecision(3, 1);
			Property(dt => dt.DateUTC).IsRequired();
		}
	}
}
