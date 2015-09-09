# TMV.DiscriminatedUnion
Simple discriminated union types for C#

# Examples
You can use the generic form directly:

```csharp
class Bike { }
class Car { }
class Lorry
{
	private readonly double _Weight;
	public double Weight { get { return _Weight; } }
	public Lorry(double weight)
	{
		_Weight = weight;
	}
}

...

Union<Bike, Car, Lorry> vehicle = new Union<Bike, Car, Lorry>(new Bike());
int wheels = vehicle.Match(
  Bike b => 2,
  Car c => 4,
  Lorry l => l.Weight < 18 ? then 4 : 12
);
```

Or you can extend the Union type. It's neater and safer, but you have to implement each of the constrcutors :(

```csharp
class Vehicle : Union<Bike, Car, Lorry>
{
	public Vehicle(Bike bike) : base(bike) { }
	public Vehicle(Car car) : base(car) { }
	public Vehicle(Lorry lorry) : base(lorry) { }
}

...

Vehicle vehicle = new Vehicle(new Bike());
int wheels = vehicle.Match(
  Bike b => 2,
  Car c => 4,
  Lorry l => l.Weight < 18 ? then 4 : 12
);
```
