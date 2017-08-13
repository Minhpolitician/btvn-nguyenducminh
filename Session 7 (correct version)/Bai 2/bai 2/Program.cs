using System;

using System.Collections.Generic;

namespace Rextester
{

	public class Program
	{

		static int USCLN(int a, int b)

		{            
			a=Math.Abs(a); 

			b=Math.Abs(b);            

			if (a==0 || b==0)

				return a+b;

			while (a!=b)

			{

				if(a>b)

					a=a-b;

				else

					b=b-a;
			}

			return a;

		}



		int c=0;

		int d=0;


		void Start () {


			for (int i = 0; i < 4; i++) 
			{

				List<int> list = new List<int> (new int[]{ 2, 4, 5, 7, 9, 15, 57 });



				Console.WriteLine("numbers: " + list [i]);

				if (i == 1) {

					d = USCLN (list [i - 1], list [i]);

					c = d;

				} if(i>=1){

					d = USCLN (c, list [i]);

					c=d;

				}

			}


			Console.Write("USCLN: ");

			Console.WriteLine(d);



		}

	}
}