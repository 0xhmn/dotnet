using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Linq;

namespace ACM_Test
{
	[TestClass]
	public class ACMTest
	{
		public TestContext TestContext { get; set; }
		
		[TestMethod]
		public void ACMMethod()
		{
			// Arrange
			CustomerRepository customerRepository = new CustomerRepository();
			var customerList = customerRepository.Retrive();

			// Act
			var result = customerRepository.Find(customerList, 2);
			
			/// Assert
			// Assert.IsNotNull(result);						// pass
			// Assert.AreEqual(2, result.CustomerId);			// pass
			// Assert.AreEqual("Baggins", result.LastName);		// pass

			Assert.IsNull(result);
		}

		[TestMethod]
		public void SortByName()
		{
			CustomerRepository repository = new CustomerRepository();
			var customerList = repository.Retrive();

			// Act
			var result = repository.SortByLastName(customerList);
			
			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual("Baggins", result.First().LastName);
		}

	}
}
