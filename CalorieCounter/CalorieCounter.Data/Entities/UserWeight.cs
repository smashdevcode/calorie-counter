using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Data.Entities
{
	public class UserWeight
	{
		public int UserWeightID { get; set; }
		public int UserID { get; set; }
		public decimal Weight { get; set; }
		public DateTime DateUTC { get; set; }
	}
}
