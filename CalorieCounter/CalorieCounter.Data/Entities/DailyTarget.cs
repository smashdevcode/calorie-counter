﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Data.Entities
{
	public class DailyTarget
	{
		public int DailyTargetID { get; set; }
		public int UserID { get; set; }
		public int Calories { get; set; }
		public decimal Fat { get; set; }
		public int Carbohydrates { get; set; }
		public DateTime? DateUTC { get; set; }
	}
}
