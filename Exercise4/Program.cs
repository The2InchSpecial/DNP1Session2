using Exercise4;

Car c1 = new Car("Green",2500,12,true);
Car c2 = new Car("Red", 3000,10,false);
Car c3 = new Car("Red", 1500,8,true);
Car c4 = new Car("Blue", 2750,15,false);
Car c5 = new Car("Black",3000,12,true);

List<Car> cars = new List<Car>();
cars.Add(c1);
cars.Add(c2);
cars.Add(c3);
cars.Add(c4);
cars.Add(c5);

List<Car> redCars = cars.Where(car => car.colour.Equals("Red")).ToList();
List<Car> automaticCars = cars.Where(car => car.isManualShift.Equals(false)).ToList();
Console.WriteLine("Red cars:");
foreach (var car in redCars)
{
    Console.WriteLine(car.ToString());
}

Console.WriteLine("\nAutomatic cars:");
foreach (var car in automaticCars)
{
    Console.WriteLine(car.ToString());
}
