using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentDay1
{
    class Class2UC1
	{
		public static void Coordinates()
		{

			Console.WriteLine("Enter X1 value :-");
			int X1 = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Enter Y1 value :-");
			int Y1 = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Enter X2 value :-");
			int X2 = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Enter Y2 value :-");
			int Y2 = Int32.Parse(Console.ReadLine());
			int xLength = (X1 - X2) * (Y1 - Y2);
			int yLength = (Y1 - Y2) * (Y1 - Y2);
			int Length = xLength + yLength;
			Console.WriteLine("X and Y lie length is :- " + Length);
		}


	}
}
