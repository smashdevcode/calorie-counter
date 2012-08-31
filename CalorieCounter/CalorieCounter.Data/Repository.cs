using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalorieCounter.Data.Entities;

namespace CalorieCounter.Data
{
	public class Repository : IDisposable
	{
		private Context _context;

		public Repository()
		{
			Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
			_context = new Context();
		}

		public List<User> GetUsers()
		{
			return _context.Users.ToList();
		}

		// TODO write other queries

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
