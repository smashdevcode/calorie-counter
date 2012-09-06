using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CalorieCounter.Data.Entities;

namespace CalorieCounter.Data.ModelConfigurations
{
	public class UserWeightConfiguration : EntityTypeConfiguration<UserWeight>
	{
		public UserWeightConfiguration()
		{
			Property(uw => uw.Weight).HasPrecision(4, 1);
		}
	}
}
