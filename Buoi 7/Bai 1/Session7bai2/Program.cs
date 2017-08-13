using System;

using System.Collections.Generic;

namespace Rextester
{

  public class bai2 : MonoBehaviour {


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

		List<int> lists = new List<int> ();

		for (int i = 0; i < 4; i++) {

			lists.Add (UnityEngine.Random.Range (1, 100));



			print (" the number: " + lists [i]);

			if (i == 1) {

				d = USCLN (lists [i - 1], lists [i]);

				c = d;

			} if(i>=1){

				d = USCLN (c, lists [i]);

				c=d;

			}

		}
				

		print ("USCLN: ");

		print (d);



	}

}