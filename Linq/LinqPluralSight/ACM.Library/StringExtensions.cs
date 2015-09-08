using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACM.Library
{
	public static class StringExtensions
	{
		/// <summary>
		/// converting a list of strings to case
		/// </summary>
		public static string ConvertToTitleCase(this string source)
		{
			CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
			TextInfo textInfo = cultureInfo.TextInfo;
			return textInfo.ToTitleCase(source);
		}

		public static void Main(String[] args) { }
	}
}
