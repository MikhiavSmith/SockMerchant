using System;
using System.Linq;

namespace SockMerchant
{

	class Program
	{

		static void Main(string[] args)
		{
			int n = 15;
			int[] ar = { 6, 5, 2, 3, 5, 2, 2, 1, 1, 5, 1, 3, 3, 3, 5 };
			int s = SockMerchant(n, ar);
			Console.WriteLine(s);
			Console.ReadLine();
		}

		public static int SockMerchant(int n, int[] ar)
		{
			int pairs = 0;
			var temp = ar.Distinct();

			foreach (var i in temp)
			{
				int count = 0;
				for (int j = 0; j < ar.Length; j++)
				{
					if (i == ar[j])
					{
						count++;
					}
				}
				pairs += count / 2;
			}
			return pairs;
		}
	}
}

