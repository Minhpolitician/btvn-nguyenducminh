using System;

using System.Collections.Generic;

namespace Rextester
{

	public class Program

	{

		public static void Main(string[] args)

		{


			List<int> list = new List<int>(new int[]{ 2, 4, 5, 7, 9,15,57 });


			for (int i = 0; i < list.Count; i++)

			{

				string bin = Convert.ToString(list[i], 2);

				Console.WriteLine(bin);

			}

		}

	}

}