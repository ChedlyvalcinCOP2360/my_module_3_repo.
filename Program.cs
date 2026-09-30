using System;

namespace Module3Assignment
{
class Program
{
static void Main(string[] args)
{
// 1. Create an instance using the object initializer syntax from the file
Stock myStock = new Stock { CurrentPrice = 150.50M, SharesOwned = 20 };

// 2. Display the calculated Worth property
Console.WriteLine("Total Worth: " + myStock.Worth);

// 3. Use the automatic property example from the file
Stock stock2 = new Stock { CurrentPrice = 83.12M, SharesOwned = 100 };
Console.WriteLine("Stock 2 Worth: " + stock2.Worth);
}
}

// Paste the Stock class from the professor's file here
public class Stock
{
public decimal CurrentPrice { get; set; } // Automatic property
public decimal SharesOwned { get; set; } // Automatic property

public decimal Worth
{
get { return CurrentPrice * SharesOwned; }
}
}
}
