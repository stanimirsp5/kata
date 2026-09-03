using CarLibrary.Entities;
using CarLibrary.Repository;

Console.WriteLine("Hello, World!");

// global query filter

var context = new AutoLotContext();
var carRepository = new Repository<Car>(context);
var getCar = carRepository.GetOne(1);





Console.ReadLine();