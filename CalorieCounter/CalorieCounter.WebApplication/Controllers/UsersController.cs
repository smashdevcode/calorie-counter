using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CalorieCounter.Data;
using CalorieCounter.Data.Entities;

namespace CalorieCounter.WebApplication.Controllers
{
	public class UsersController : ApiController
	{
		private Repository _repository;

		// TODO add constructor that accepts a IRepository interface
		public UsersController()
		{
			_repository = new Repository(true);
		}

		public IEnumerable<User> GetUsers()
		{
			return _repository.GetUsers();
		}
	}
}