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

