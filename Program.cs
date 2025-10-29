using LinqForCSharpDevelopers;

var cars = CarRepository.GetCars();

#region #1 Introduction to LINQ

//var result = from c in cars
//             where c.Make == "Ford" && c.Model == "Mustang"
//             select c;


//var result = from c in cars
//             where c.Make == "Ford"
//             where c.Model == "Mustang"
//             select c;

//var result = from c in cars
//             where c.Make == "Ford"
//             && c.VIN.StartsWith("W")
//                select c;



//var result = cars.Where(c => c.Make == "Ford" && c.Model == "Mustang");

//var result = cars.
//    Where(c => c.Make == "Ford" || c.Model == "Mustang")
//    .Where(result => result.VIN.StartsWith("W"));

//var result = cars.Select(result => result);

//var result = cars.Where(IsFord);


//CarRepository.PrintCars(result);

//static bool IsFord(Car car) => car.Make == "Ford";

#endregion


#region #2 - Find the first car made by "Volvo"

//var result = (from c in cars
//              where c.Make == "Volvo"
//              select c )
//              .First();

//var result = cars.First(f => f.Make == "Volvo");
//var result = cars.Where(c => c.Make == "Volvo")
//                 .First();

//CarRepository.PrintCars([result]);
#endregion




#region #3 fist or default


//List<string> ListString = new List<string> { "One","Too", "Two", "Three" };

//var result = ListString.FirstOrDefault();

//Console.WriteLine(result);



//result = ListString.FirstOrDefault( n => n.StartsWith("T"));

//Console.WriteLine(result);


//result = ListString.FirstOrDefault(n => n.StartsWith("S"));

//Console.WriteLine(result);


//result = ListString.Single(n => n.StartsWith("T"));//will reutrn exception if more than one element found
//Console.WriteLine(result);


//int[] numbers = [];
//var result = numbers.FirstOrDefault().ToString();
//Console.WriteLine(result ?? "No elements found");


//var defalutcar =new Car(Id: 0, Make: "No Make", Model: "No Model", ManufactureYear: 0, VIN: "No VIN",  Color: "red", MaxSpeed: 290);

//var result1 = cars.FirstOrDefault(n => n.Make == "Teslax", defalutcar);
//CarRepository.PrintCars([result1]);

#endregion