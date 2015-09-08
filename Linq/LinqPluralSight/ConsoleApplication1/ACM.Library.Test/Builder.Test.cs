using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Library;

namespace ACM.Library.Test
{
	[TestClass]
    public class BuilderTest
    {
		public TestContext TestContext { get; set; }

		[TestMethod]
		public void BuildIntegerSequenceTest()
		{
			Builder listBuilder = new Builder();

			// Act
			var result = listBuilder.BuildStringSequence();
			foreach (var item in result)
			{
				TestContext.WriteLine(item.ToString());
			}

			Assert.IsNotNull(result);
		}
    }
}
