using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Data.Entities
{
	public class FoodItem
	{
		public int FoodItemID { get; set; }
		public int? UserID { get; set; }
		public string Name { get; set; }
		public int Calories { get; set; }
		public decimal Fat { get; set; }
		public int Carbohydrates { get; set; }
		public string ServingSize { get; set; }
	}
}
