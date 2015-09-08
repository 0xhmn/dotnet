using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Library
{
	public class Builder
	{
		/// <summary>
		/// doing operations on every list member, like a range list using "select"
		/// </summary>
		public IEnumerable<int> BuildIntegerSequence()
		{
			var integers = Enumerable.Range(0, 10)
						.Select(i => (i * (i+2)));
			return integers;
		}

		public IEnumerable<string> BuildStringSequence()
		{
			var strings = Enumerable.Range(0, 10)
						.Select(i => ((char)('A' + i)).ToString());
			var anotherStrings = Enumerable.Range(0, 10)
						.Select(i => (Convert.ToChar('A' + i)).ToString());

			return anotherStrings;
		}

		public void MakingAnArrayByUser()
		{
			Console.WriteLine("how many numbers do you want to store?");
			int range = Int16.Parse(Console.ReadLine());
			Console.WriteLine("{0} many numbers", range);

			int[] numbers = new int[range];
			for (int i = 0; i < range; i++)
			{
				numbers[i] = Int16.Parse(Console.ReadLine());
			}

			var result = numbers.Where(i => i > 10);
			foreach (var n in result)
			{
				Console.WriteLine(n);
			}

			Console.ReadLine();
		}
	}
}
