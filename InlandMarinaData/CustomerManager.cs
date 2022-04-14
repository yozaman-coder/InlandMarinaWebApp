using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    public class CustomerManager
    {
		/// <summary>
		/// Adds customer to database
		/// </summary>
		/// <param name="customer">Customer to add</param>
		public static void AddCustomer(Customer customer)
        {
			InlandMarinaContext db = new InlandMarinaContext();
			db.Customers.Add(customer);
			db.SaveChanges();
		}

		//public static int GetNewCustomerID()
		//      {
		//	InlandMarinaContext db = new InlandMarinaContext();
		//	int lastCustomer = db.Customers.OrderBy(id => id.ID).Select(id => id.ID).Last();
		//	int newCustomer = lastCustomer + 1;
		//	return newCustomer;
		//      }
		/// <summary>
		/// User is authenticated based on credentials and a user returned if exists or null if not.
		/// </summary>
		/// <param name="username">Username as a string</param>
		/// <param name="password">Password as a string</param>
		/// <returns> A user object or null </returns>
		///   /// <remarks>
		/// Add additional for the docs for this application--for developers.
		/// </remarks>
		public static Customer Authenticate(string username, string password)
        {
			InlandMarinaContext db = new InlandMarinaContext();
			// Has to be first or default or picks up two customers if they have the same info
			var user = db.Customers.FirstOrDefault(cst => cst.Username == username
											&& cst.Password == password);
			return user;// This will either be null or an object
			
		
        }
    }
}
