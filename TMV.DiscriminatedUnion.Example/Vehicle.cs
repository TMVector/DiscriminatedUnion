using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMV.DiscriminatedUnion.Example
{
	class Bike { public static readonly Bike Instance = new Bike(); }
	class Car { public static readonly Car Instance = new Car(); }
	class Lorry
	{
		private readonly double _Weight;
		public double Weight { get { return _Weight; } }
		public Lorry(double weight)
		{
			_Weight = weight;
		}
	}

	class Vehicle : Union<Bike, Car, Lorry>
	{
		public Vehicle(Bike bike) : base(bike) { }
		public Vehicle(Car car) : base(car) { }
		public Vehicle(Lorry lorry) : base(lorry) { }
	}
}
