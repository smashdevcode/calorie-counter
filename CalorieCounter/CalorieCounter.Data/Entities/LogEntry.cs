using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.Data.Entities
{
	public class LogEntry
	{
		public int LogEntryID { get; set; }
		public int UserID { get; set; }
		public int MealTypeID { get; set; }
		public DateTime DateTimeUTC { get; set; }
	}
}
