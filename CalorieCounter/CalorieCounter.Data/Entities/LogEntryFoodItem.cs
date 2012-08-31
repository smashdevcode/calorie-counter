using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Data.Entities
{
	public class LogEntryFoodItem
	{
		public int LogEntryFoodItemID { get; set; }
		public int LogEntryID { get; set; }
		public int FoodItemID { get; set; }
		public decimal Serving { get; set; }
	}
}
