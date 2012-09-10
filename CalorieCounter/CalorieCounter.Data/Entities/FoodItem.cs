using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Data.Entities
{
	public class FoodItem
	{
        public FoodItem()
        {
            FoodItemParts = new List<FoodItemPart>();
            ContainedByFoodItemParts = new List<FoodItemPart>();
        }

		public int FoodItemID { get; set; }
		public int? UserID { get; set; }
		public string Name { get; set; }
        public string ServingSize { get; set; }
        // TODO update the next three getters to check the food item parts collection
		// and if not null, use that to calculate the values
		public int? Calories { get; set; }
        //public decimal? Fat { get; set; }
        //public int? Carbohydrates { get; set; }

		public User User { get; set; }
		public List<FoodItemPart> FoodItemParts { get; set; }
		public List<FoodItemPart> ContainedByFoodItemParts { get; set; }
	}
}
