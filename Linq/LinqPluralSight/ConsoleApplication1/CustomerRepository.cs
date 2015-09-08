using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	public class CustomerRepository
	{
		/// <summary>
		/// finding a customer with the id	
		/// </summary>
		public Customer Find(List<Customer> customerList, int customerId)
		{
			Customer foundCustomer = null;

			/**
			 * replacing this foreach loop with a Linq query
			 */
			//foreach (Customer customer in customerList)
			//{
			//	if (customer.CustomerId == customerId)
			//	{
			//		foundCustomer = customer;
			//		break;
			//	}
			//}

			//var query = from c in customerList
			//			where c.CustomerId == customerId
			//			select c;
			//foundCustomer = query.First();

			/// method one - using Where Extensiom method
			var query_method_syntax = customerList.Where(c => c.CustomerId == customerId);
			/// method two - using First + Lambda Extension method
			/// this will throw an exception if no match is found
			var query_method_syntax_2 = customerList.First(c => c.CustomerId == customerId);
			/// method three - doesnt throw an exception if no match is found
			var query_method_syntax_3 = customerList.FirstOrDefault(c => c.CustomerId == customerId);
			/// we can re-write the above lambda expression in more than one line
			var query_method_syntax_4 = customerList.FirstOrDefault(c =>
			{
				Debug.WriteLine(string.Format("The name is {0}", c.LastName));
				return c.CustomerId == customerId;
			});
			/// what if we want to find the second match instead of the first match
			var query_method_syntax_5 = customerList.Where(c =>
										c.CustomerId == customerId)
										.Skip(1)
										.FirstOrDefault();

			foundCustomer = query_method_syntax_5;
			return foundCustomer;
		}

		/// <summary>
		/// sorting by last name and then sort by First Name
		/// </summary>
		public IEnumerable<Customer> SortByLastName(List<Customer> customerList)
		{
			return customerList.OrderBy(c => c.LastName)
				.ThenBy(c => c.FirstName);
		}

		/// <summary>
		/// reverse sorting by name
		/// </summary>
		public IEnumerable<Customer> SortByNameInRevese(List<Customer> customerList)
		{
			return customerList.OrderByDescending(c => c.LastName);
		}


		public List<Customer> Retrive()
		{
			List<Customer> custList = new List<Customer>
                    {new Customer() 
                          { CustomerId = 1, 
                            FirstName="Frodo",
                            LastName = "Baggins",
                            EmailAddress = "fb@hob.me",
                            CustomerTypeId=1},
                    new Customer() 
                          { CustomerId = 2, 
                            FirstName="Bilbo",
                            LastName = "Baggins",
                            EmailAddress = "bb@hob.me",
                            CustomerTypeId=null},
                    new Customer() 
                          { CustomerId = 3, 
                            FirstName="Samwise",
                            LastName = "Gamgee",
                            EmailAddress = "sg@hob.me",
                            CustomerTypeId=1},
                    new Customer() 
                          { CustomerId = 4, 
                            FirstName="Rosie",
                            LastName = "Cotton",
                            EmailAddress = "rc@hob.me",
                            CustomerTypeId=2}};
			return custList;
		}

	}
}
