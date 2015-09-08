using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.Library.Test
{
	[TestClass]
	public class UnitTest1
	{
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void TestMethod1()
		{		
			// Arrange
			string test = "this is a sample case";
			string target = "This Is A Sample Case";

			// Act
			// var result = StringExtensions.ConvertToTitleCase(test);
			/// after adding "this" keyword to our Extension method
			var result = test.ConvertToTitleCase();

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual(result, target);


		}
	}
}
