﻿using System;
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
		}
	}
}