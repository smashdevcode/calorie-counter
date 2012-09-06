using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Data.Entities
{
	public class User
	{
		public int UserID { get; set; }
		// TODO use oAuth instead???
		public string Username { get; set; }
		public string HashedPassword { get; set; }
		public string Name { get; set; }
		// TODO how to add unique constraint???
		public string Email { get; set; }
		// TODO do we need to store this???
		// can't we just get this information from the browser???
		public string TimeZone { get; set; }

		public List<UserWeight> Weights { get; set; }
		public List<DailyTarget> DailyTargets { get; set; }
		public List<FoodItem> FoodItems { get; set; }
		public List<LogEntry> LogEntries { get; set; }
	}
}
