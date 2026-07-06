Console.WriteLine("Hello, World!");

var car = new CarLibrary.Car
{
	Brand = "Toyota",
	Model = "Camry",
	Year = 2022
};

var activateBoost = false;

Console.WriteLine("Do you want to activate turbo boost? (yes/no)");
var input = Console.ReadLine();
if (input?.ToLower() == "yes" || input?.ToLower() == "y")
{
	activateBoost = true;
}

if(activateBoost)
{
	car.TurboBoost();
}
else
{
	Console.WriteLine("Turbo boost not activated.");
}
Console.ReadLine();

// Create .il file in the CarLibrary folder:
// ildasm /all /METADATA /out=.\CarLibrary\CarLibrary.il .\CarLibrary\bin\Debug\net10.0\CarLibrary.dll
//Compile .il file to .dll file in the CarLibrary folder:
// ilasm /DLL CarLibrary.il /x64
// ilasm /dll /output=.\CarLibrary\CarLibrary.dll .\CarLibrary\CarLibrary.il