using LearnLINQ;
using LinqForCSharpDevelopers;
using YouTubeLINQ;

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


#region #6 immediate execution vs deferred execution

//var result = cars.Where(IsVolvo);//deferred execution
//static bool IsVolvo(Car car)
//{
//    //if i make a breakpoint here the program will not stop because this is deferred execution
//    return car.Make == "Volvo";
//}


//var result = cars.First(IsVolvo);//immediate execution
//static bool IsVolvo(Car car)
//{
//    //if i make a breakpoint here the program will stop because this is immediat4e execution
//    return car.Make == "Volvo";
//}


#endregion


#region Data Ordering
//part 1
//var result = from c in cars
//             orderby c.MaxSpeed
//             select c;

//var result = cars.OrderBy(c => c.ManufactureYear);

//var result = cars.OrderByDescending(ordering);

//CarRepository.PrintCars(result);

//part 2
//static int ordering(Car c) => c.ManufactureYear;

//var result = from c in cars
//             orderby c.Make, c.Model, c.MaxSpeed descending
//             select c;


//var result = cars.OrderBy(c => c.Make)
//        .ThenBy(c => c.Model)
//        .ThenByDescending(c => c.MaxSpeed);

//CarRepository.PrintCars(result);

//part 3
//int[] numbers = [5, 3, 8, 1, 4];
//string[] names = ["admed","mohamed","karem","ali","bary"];

//var result = numbers.Order();
//var nameresult = names.Order();

//foreach (int n in result)
//{
//    Console.WriteLine(n);
//}

//foreach(int n in result.OrderDescending())
//{
//    Console.WriteLine(n);
//}

//foreach (string name in nameresult.Order())
//{
//    Console.WriteLine(name);
//}

//cutome comparer
//var result = cars.Order(new CarComparer());
//CarRepository.PrintCars(result);

#endregion




#region #8 any() and all()

//any get any element that match the condition
//cars = [];
//var result = cars.Any(c => c.Make == "Ford" || c.Color == "bule");

//Console.WriteLine(result? "found" : "not found");

//all check if all the elements match the condition
//var result = cars.All(c => c.ManufactureYear > 2000);
//Console.WriteLine(result ? "all cars are new" : "not all cars are new");


#endregion


#region #9 append() and prepend()

//var EndCar = new Car(Id: 1001, Make: "Tesla", Model: "Model S", ManufactureYear: 2022, VIN: "5YJSA1E26JF256789", Color: "White", MaxSpeed: 250);
//var FirstCar = new Car(Id: 0, Make: "BMW", Model: "i8", ManufactureYear: 2021, VIN: "WBY2Z6C57JV123456", Color: "Black", MaxSpeed: 240);

//var result = cars.Append(EndCar);

//result = result.Prepend(FirstCar);
//CarRepository.PrintCars(result);


#endregion

#region #10 using Count and logCount and CountBy

//var totalCount = cars.Count();
//var totalFordCarCount = cars.Count(c => c.Make == "Ford");

////will return exception if value greater than int 32 maximal value
//Console.WriteLine($"Total cars count: {totalCount}");
//Console.WriteLine($"Total Ford cars count: {totalFordCarCount}");

////will return exception if value greater than int 64 maximal value
//var totalLongCount = cars.LongCount();
//Console.WriteLine($"Total cars count using LongCount: {totalLongCount}");

//count by new in .NET 9
//var countByMake = cars.CountBy(c => c.Make).OrderByDescending(cars => cars.Value);
//foreach (var kvp in countByMake)
//{
//    Console.WriteLine($"{kvp.Key} --> {kvp.Value}");
//}


//var countByMake = cars.CountBy(c => $"{c.Make}-{c.Color}").OrderBy(cars => cars.Key);
//foreach (var kvp in countByMake)
//{
//    Console.WriteLine($"{kvp.Key} --> {kvp.Value}");
//}

#endregion


#region #11 SUM

//double[] numbers = [5.7, 10.2, 15, 20, 25];
//var result = numbers.Sum();
//Console.WriteLine($"The sum is: {result}");

var expenses = ExpensesRepository.GetExpenses();


var totalIncome = expenses
    .Where(e => e.Type == ExpensesType.Income)
    .Sum(e => e.Amount);//select the Amount property and sum it



var totalOutcome = expenses
    .Where(e => e.Type == ExpensesType.Outcome)
    .Sum (e => e.Amount);

ExpensesRepository.PrintDate(expenses);
Console.WriteLine($"Total Income: {totalIncome:F2}");
Console.WriteLine($"Total Outcome: {totalOutcome:F2}");


/* concept of interpolated strings
 double value = 1234.5678;

Console.WriteLine($"F2: {value:F2}");//fixed-point with 2 decimal places
Console.WriteLine($"N2: {value:N2}");//number with 2 decimal places and thousands separator
Console.WriteLine($"C2: {value:C2}");//currency with 2 decimal places
Console.WriteLine($"P2: {0.1234:P2}");//percentage with 2 decimal places
Console.WriteLine($"E2: {value:E2}");//scientific notation with 2 decimal places

 //output:
F2: 1234.57
N2: 1,234.57
C2: $1,234.57
P2: 12.34%
E2: 1.23E+03

 */

#endregion