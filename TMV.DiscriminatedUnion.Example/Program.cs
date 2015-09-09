using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMV.DiscriminatedUnion.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle vehicle = new Vehicle(Bike.Instance);

			int wheels = vehicle.Match(
				(Bike b)	=> 2,
				(Car c)		=> 4,
				(Lorry l)	=> l.Weight < 18 ? 4 : 12
			);

			Console.WriteLine("A bike has {0} wheels", wheels);
		}
	}
}
