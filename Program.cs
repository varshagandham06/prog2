﻿using System;

namespace prog2
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, m = 0, flag = 0;
			int n = 3;
			m = n / 2;
			if (n == 0 || n == 1)
			{
				Console.WriteLine(n + " is not prime number");
			}
			else
			{
				for (i = 2; i <= m; i++)
				{
					if (n % i == 0)
					{
						Console.WriteLine(n + " is not prime number");
						flag = 1;
						break;
					}
				}
				if (flag == 0)
				{
					Console.WriteLine(n + " is prime number");
				}
			}
		}
	}
}
