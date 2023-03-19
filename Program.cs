using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Learning
{
	class Program
	{
		static void Main()
		{
			string starpicture = "";
			int i, j;
			for (i = 0; i < 5; ++i)
			{
				starpicture = "";
				for (j = i; j < 5 - 1; ++j)
				{
					starpicture += "★";
				}
				for (j = 0; j <= i * 2; ++j)
				{
					starpicture += "☆";
				}
				for (j = i; j < 5 - 1; ++j)
				{
					starpicture += "★";
				}
				Console.WriteLine(starpicture);
			}
			for (i = 0; i < 4; ++i)
			{
				starpicture = "";

				for (j = 0; j <= i; ++j)
				{
					starpicture += "★";
				}
				for (j = i * 2; j < 4 * 2 - 1; ++j)
				{
					starpicture += "☆";
				}
				for (j = 0; j <= i; ++j)
				{
					starpicture += "★";
				}
				Console.WriteLine(starpicture);
			}
		}
	}
}