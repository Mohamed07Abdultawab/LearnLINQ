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

//var expenses = ExpensesRepository.GetExpenses();


//var totalIncome = expenses
//    .Where(e => e.Type == ExpensesType.Income)
//    .Sum(e => e.Amount);//select the Amount property and sum it



//var totalOutcome = expenses
//    .Where(e => e.Type == ExpensesType.Outcome)
//    .Sum (e => e.Amount);

//ExpensesRepository.PrintDate(expenses);
//Console.WriteLine($"Total Income: {totalIncome:F2}");
//Console.WriteLine($"Total Outcome: {totalOutcome:F2}");


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


#region #12 Average

//double[] numbers = [5.7, 10.2, 15, 20, 25];
//var result = numbers.Average();
//Console.WriteLine($"The average is: {result:F2}");

//var speedAverage = cars
//    .Where(c => c.Make == "Ford")
//    .Average(c => c.MaxSpeed);
//Console.WriteLine($"The average car speed is: {speedAverage:F2} km/h");


//string[] names = ["Ahmed", "Mohamed", "Karem", "Ali", "Bary"];
//var nameLengthAverage = names.Average(n => n.Length);
//Console.WriteLine($"The average name length is: {nameLengthAverage:F2} characters");


//string[] numbers = ["10", "20", "30", "404444", "50"];
//var numberAverage = numbers.Average(n => int.Parse(n));
//Console.WriteLine($"The average number is: {numberAverage:N2}");

//var expenses = ExpensesRepository.GetExpenses();
//var averageIncome = expenses
//    .Where(e => e.Type == ExpensesType.Income)
//    .Average(e => e.Amount);
//Console.WriteLine($"The average income is: {averageIncome:F2}");

#endregion


#region #13 Min and MinBy and Max and MaxBy

//int[] numbers = [5, 10, 3, 8, 1, 4];
//var maxNumber = numbers.Max();
//Console.WriteLine($"The maximum number is: {maxNumber}");


//var maxSpeed = cars.Max(c => c.MaxSpeed);
//Console.WriteLine($"The maximum car speed is: {maxSpeed} km/h");

//var maxMakeLength = cars.Max(c => c.Make.Length);
//Console.WriteLine($"The maximum car make length is: {maxMakeLength} characters");

//var minSpeed = cars.Min(c => c.MaxSpeed);
//Console.WriteLine($"The minimum car speed is: {minSpeed} km/h");


//maxBy and minBy new in .NET 6
//Car FastertCar = cars.MaxBy(c => c.MaxSpeed);
//CarRepository.PrintCars([FastertCar]);

//Car LowerCar = cars.MinBy(c => c.MaxSpeed);
//CarRepository.PrintCars([LowerCar]);


#endregion

#region Aggregate

//int[] numbers = [1, 2, 3, 4, 5];

//var result = numbers.Aggregate((acc, next) =>
//    {
//    Console.WriteLine($"accc: {acc}, next: {next}");
//        return acc + next;
//    });

//Console.WriteLine($"The aggregate sum is: {result}");


//string sentence = "LINQ is a powerful feature in C#";
//string[] words = sentence.Split(' ');
//string reversed = words.Aggregate((acc, next) =>
//{
//    Console.WriteLine($"acc: {acc}, next: {next}");
//    return next + " " + acc;
//});
//Console.WriteLine($"Reversed sentence: {reversed}");

//part 2

//int[] numbers = [1, 2, 3, 4, 5,6,7,8,9,10];
////with seed value`
//var result = numbers.Aggregate(0,(total, next) =>
//    {
//        Console.WriteLine($"total: {total}, next: {next}");
//       return next % 2 == 0 ? total + 1 : total;
//    });

//Console.WriteLine($"The aggregate sum of even numbers is: {result}");


////adjust in final result
//string[] fruits = ["apple", "banana", "orange", "grape", "kiwi"];
//string longestFruitName = fruits.Aggregate("banana", (longest, next) =>

//{
//    Console.WriteLine($"longest: {longest}, next: {next}");
//    return next.Length > longest.Length ? next : longest;
//},
//    //return the final result as upper case
//    fruits => fruits.ToUpper());

//Console.WriteLine($"The longest fruit name is: {longestFruitName}");


#endregion


#region Shape using Select

//var result = from c in cars
//             select new CarDto(c.Id,c.Make,$"{c.Model} : {c.Color}", c.ManufactureYear);


//var result = cars.Select(c => new CarDto(c.Id, c.Make, c.Model, c.ManufactureYear));

//var result = cars.Select((c,i) => new CarDto(c.Id, c.Make, c.Model, c.ManufactureYear,i));//with index

//foreach (var carDto in result)
//{
//    Console.WriteLine(carDto.Index);
//    Console.WriteLine($"\t{carDto.Make}\t{carDto.Model}\t{carDto.Year}\t{carDto.Index}");
//}

//can also customize many properties
//var result = cars.Select((c,i) => new CarDto(c.Id, c.Make, c.Model, c.ManufactureYear,i,$"{i} - {c.MaxSpeed}"));

//foreach (var carDto in result)
//{
//    Console.WriteLine(carDto.Index);
//    Console.WriteLine($"\t{carDto.Make}\t{carDto.Model}\t{carDto.Year}\t{carDto.Index}\t{carDto.Dummy}");
//}



#endregion

IEnumerable<Car2> cars2 =
    [
        new Car2(
            Id: 1,
            Make: "Ford",
            Model: "Mustang",
            ManufactureYear: 2020,
            VIN: "1FA6P8TH0L5100001",
            Color: "Red",
            MaxSpeed: 250,
            Safety: ["Airbags", "ABS", "Traction Control"]
        ),
        new Car2(
            Id: 2,
            Make: "Volvo",
            Model: "XC90",
            ManufactureYear: 2021,
            VIN: "YV4A22PK0M1234567",
            Color: "Blue",
            MaxSpeed: 230,
            Safety: ["Airbags", "Lane Assist", "Blind Spot Monitoring"]
        ),
        new Car2(
            Id: 3,
            Make: "Toyota",
            Model: "Camry",
            ManufactureYear: 2019,
            VIN: "4T1BF1FK5KU123456",
            Color: "White",
            MaxSpeed: 220,
            Safety: ["Airbags", "ABS", "Pre-Collision System"]
        ),
        new Car2(
            Id: 4,
            Make: "Honda",
            Model: "Civic",
            ManufactureYear: 2018,
            VIN: "2HGFC2F59JH123456",
            Color: "Black",
            MaxSpeed: 210,
            Safety: ["Airbags", "Lane Departure Warning", "Adaptive Cruise Control"]
        ),
        new Car2(
            Id: 5,
            Make: "BMW",
            Model: "X5",
            ManufactureYear: 2022,
            VIN: "5UXCR6C05M9D12345",
            Color: "Silver",
            MaxSpeed: 240,
            Safety: ["Airbags", "ABS", "Parking Sensors"]
        ),
        new Car2(
            Id: 5,
            Make: "BMW",
            Model: "X5",
            ManufactureYear: 2022,
            VIN: "5UXCR6C05M9D12345",
            Color: "Silver",
            MaxSpeed: 240,
            Safety: ["Airbags", "ABS", "Parking Sensors"]
        )
    ];

#region SelectMany

//without using select many
//List<string> allSafety = [];
//foreach (var car in cars2)
//{
//    foreach(var safety in car.Safety)
//    {
//        allSafety.Add(safety);
//    }
//}
//foreach(var safety in allSafety.Distinct())
//{
//    Console.WriteLine(safety);
//}

//var allValues = from c in cars2
//                from s in c.Safety
//                select s;
//foreach (var safety in allValues.Distinct())
//{
//    Console.WriteLine(safety);
//}

//using select many
//var allValues = cars2.SelectMany(c => c.Safety);
//foreach (var safety in allValues.Distinct())
//{
//    Console.WriteLine(safety);
//}

//var allValues = cars2.SelectMany((c,i) => c.Safety.Select(s => $"{i} : {s}"));
//foreach (var safety in allValues.Distinct())
//{
//    Console.WriteLine(safety);
//}

//var allValues = cars2.SelectMany(c => c.Safety, (c,s) => new { DisplayValues = $"{c.Make} - {s}"});
//foreach (var safety in allValues.Distinct())
//{
//    Console.WriteLine(safety);
//}



//var allValues = cars2.Select(c => new CarDto(c.Id, c.Make, c.Model, c.ManufactureYear, string.Join(',', c.Safety)));
//foreach (var carDto in allValues)
//{
//    Console.WriteLine($"{carDto.Make}\t{carDto.Model}\t{carDto.Year}\t{carDto.Safety}");
//}


#endregion


#region Distinct and DistinctBy
//distinct
//int[] numbers = [1, 2, 3, 2, 4, 5, 1, 6, 3, 7, 8, 5];
//var distinctNumbers = numbers.Distinct();
//foreach (var n in distinctNumbers)
//{
//    Console.WriteLine(n);
//}



//distinct by
//var allValues = cars2.DistinctBy(c => c.Id);//exit two cars with same id (id 5)
//foreach (var item in allValues)
//{
//    Console.WriteLine(item);
//}

#endregion


#region GroupBy

//var result = from c in cars
//             group c by new { c.Make, c.Color };

var result = cars.GroupBy(c => new { c.Make, c.Color });

foreach (var group in result)
{
    Console.WriteLine($"Make and Color: {group.Key} - Total Cars: {group.Count()}");
    CarRepository.PrintCars(group);
}




#endregion