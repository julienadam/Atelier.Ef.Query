using Atelier.Ef.Query.Entities;
using Microsoft.EntityFrameworkCore;

using var context = new NorthwindContext();

//var e1 = context.Employees.Single(e => e.EmployeeId == 1);
//Console.WriteLine($"{e1.FirstName} {e1.LastName}");

//var americanEmployees = context.Employees.Where(e => e.Country == "USA");

//foreach(var e in americanEmployees)
//{
//    Console.WriteLine($"{e.FirstName} {e.LastName}");
//}

//var americanEmployeeNames = context.Employees.Where(e => e.Country == "USA").Select(e => new { e.FirstName, e.LastName });
//foreach (var e in americanEmployeeNames)
//{
//    Console.WriteLine($"{e.FirstName} {e.LastName}");
//}

//var pageSize = 20;
//var numRes = context.Orders.Where(o => o.EmployeeId == 1).Count();
//var totalPages = (int)Math.Ceiling((double)numRes / (double)pageSize);

//for (var pageNumber = 0; pageNumber < totalPages; pageNumber++)
//{
//    foreach (var order in context.Orders
//        .Where(o => o.EmployeeId == 1)
//        .OrderBy(o => o.OrderDate)
//        .ThenBy(o => o.OrderId)
//        .Skip(pageNumber * pageSize)
//        .Take(pageSize)
//        .ToList())
//    {
//        Console.WriteLine($"{order.CustomerId} {order.ShipName} {order.ShipAddress} {order.ShipCity} {order.ShipCountry}");
//    }
//    Console.WriteLine($"Press enter to continue (page {pageNumber + 1}/{totalPages})");
//    Console.ReadLine();
//}

//var pageSize = 20;
//var lastOrderId = -1;
//var pageNumber = 1;
//while(true)
//{
//    var page = context.Orders
//        .Where(o => o.EmployeeId == 1)
//        .OrderBy(o => o.OrderDate)
//        .ThenBy(o => o.OrderId)
//        .Where(o => o.OrderId > lastOrderId)
//        .Take(pageSize)
//        .ToList();

//    if (page.Count == 0)
//    {
//        break;
//    }
//    else
//    {
//        foreach (var order in page)
//        {
//            Console.WriteLine($"{order.CustomerId} {order.ShipName} {order.ShipAddress} {order.ShipCity} {order.ShipCountry}");
//        }
//        Console.WriteLine($"Press enter to continue (page {pageNumber}");
//        Console.ReadLine();

//        lastOrderId = page.Last().OrderId;
//        pageNumber++;
//    }
//}

//var shippedIn1998ByEmployee = context.Orders
//    .Where(o => o.ShippedDate >= new DateTime(1998, 1, 1) && o.ShippedDate < new DateTime(1999, 1, 1))
//    .GroupBy(o => o.EmployeeId)
//    .Select(g => new { EmployeeId = g.Key, TotalExpedie = g.Sum(o => o.Freight) })
//    .ToList();

//foreach(var s in shippedIn1998ByEmployee)
//{
//    Console.WriteLine($"{s.EmployeeId} shipped {s.TotalExpedie}");
//}

//foreach(var c in context.Customers.Where(c => c.CustomerId.Sum(i => (int)i) == 368).Select(c => c.CustomerId))
//{
//    Console.WriteLine($"{c}");
//}

//foreach (var c in context.Customers.AsEnumerable().Where(c => c.CustomerId.Sum(i => (int)i) == 368))
//{
//    Console.WriteLine($"{c.CustomerId}");
//}

//var employee = context.Employees.Single(e => e.FirstName == "Nancy" && e.LastName == "Davolio");

//foreach(var o in employee.Orders)
//{ 
//    Console.WriteLine($"{o.CustomerId}"); 
//}

//var employee = context.Employees
//    .Include(e => e.Orders)
//    .Single(e => e.FirstName == "Nancy" && e.LastName == "Davolio");

//foreach (var o in employee.Orders)
//{
//    Console.WriteLine($"{o.CustomerId}");
//}

//var employee = context.Employees
//    .Include(e => e.Orders.Where(o => o.OrderDate >= new DateTime(1997,1,1) && o.OrderDate < new DateTime(1998, 1, 1)))
//    .Single(e => e.FirstName == "Nancy" && e.LastName == "Davolio");

//foreach (var o in employee.Orders)
//{
//    Console.WriteLine($"{o.CustomerId}");
//}

//var employee = context.Employees
//    .Include(e => e.Orders)
//    .ThenInclude(o => o.Customer)
//    .Single(e => e.FirstName == "Nancy" && e.LastName == "Davolio");

//foreach (var o in employee.Orders)
//{
//    Console.WriteLine($"{o.CustomerId} {o.Customer?.CompanyName}");
//}

//var employee = context.Employees
//    .Include(e => e.Orders)
//    .ThenInclude(o => o.Customer)
//    .AsSplitQuery()
//    .Single(e => e.FirstName == "Nancy" && e.LastName == "Davolio");

//foreach (var o in employee.Orders)
//{
//    Console.WriteLine($"{o.CustomerId} {o.Customer?.CompanyName}");
//}

//var employee = context.Employees.Single(e => e.FirstName == "Nancy" && e.LastName == "Davolio");
//Console.WriteLine("Charger les commandes ?");
//Console.ReadLine();
//context.Entry(employee).Collection(e => e.Orders).Load();
//foreach (var o in employee.Orders)
//{
//    Console.WriteLine($"{o.CustomerId} {o.Customer?.CompanyName}");
//}

foreach(var t in context.Territories)
{
    Console.WriteLine($"{t.TerritoryDescription} {t.Region.RegionDescription}");
}