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


#region #4 last and last or default

//var result = cars.Last(cars => cars.Make == "Ford");
//CarRepository.PrintCars([result]);


//var result = (from c in cars
//              where c.Make == "Ford"
//              select c)
//              .LastOrDefault();

//var result = cars.LastOrDefault(cars => cars.Make == "Ford");

//CarRepository.PrintCars([result]);

//var defalutcar = new Car(Id: 0, Make: "No Make", Model: "No Model", ManufactureYear: 0, VIN: "No VIN",  Color: "red", MaxSpeed: 290);

//var result = cars.LastOrDefault(cars => cars.Make == "Fordx",defalutcar);

//CarRepository.PrintCars([result]);


#endregion


#region #5 single and single or default

//var result = cars.Single(c => c.Make == "Volvo" && c.VIN == "JTHBK1GGXF2728528");
//var defalutcar = new Car(Id: 0, Make: "No Make", Model: "No Model", ManufactureYear: 0, VIN: "No VIN",  Color: "red", MaxSpeed: 290);

//cars = [defalutcar];
//var result = cars.Single();

//var result = cars.Single(IsFord);

//CarRepository.PrintCars([result]);

//static bool IsFord(Car car) => car.Make == "Ford";

//cars = [];
//var result = cars.SingleOrDefault();

//CarRepository.PrintCars([result]);


#endregion