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

		public Repository(bool dropAndCreateDatabaseIfModelChanges = false)
		{
			if (dropAndCreateDatabaseIfModelChanges)
				Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());

			_context = new Context();
		}

		public List<User> GetUsers()
		{
			return _context.Users.ToList();
		}
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

		// TODO write other queries

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
