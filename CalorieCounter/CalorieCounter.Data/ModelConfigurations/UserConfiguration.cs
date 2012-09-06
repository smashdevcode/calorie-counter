using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using CalorieCounter.Data.Entities;

namespace CalorieCounter.Data.ModelConfigurations
{
	public class UserConfiguration : EntityTypeConfiguration<User>
	{
		public UserConfiguration()
		{
			Property(u => u.Username).HasMaxLength(20).IsRequired();
			// TODO max length of hashed password???
			Property(u => u.HashedPassword).IsRequired();
			Property(u => u.Name).HasMaxLength(50).IsRequired();
			Property(u => u.Email).HasMaxLength(255).IsRequired();
			// TODO create time zone table??? use enums???
			Property(u => u.TimeZone).HasMaxLength(100).IsRequired();
		}
	}
}
