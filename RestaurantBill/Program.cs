Console.WriteLine("***** Welcome to Restaurant Bill App *****\n");

Console.WriteLine("Please enter the charge of the meal: ");
Console.WriteLine("");

decimal mealPrice = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("\n");

Console.WriteLine("***************************************\n");

const decimal TAX_RATE = 0.0675m;
const decimal TIP = 0.2m;
decimal taxAmount = mealPrice * TAX_RATE;
decimal tipAmount = mealPrice * TIP;
decimal totalAmount = mealPrice + taxAmount + tipAmount;

Console.WriteLine($"The meal charge is ${mealPrice}.");
Console.WriteLine("The tax amount is $" + Math.Round(taxAmount, 2) + ".");
Console.WriteLine("The tip amount is $" + Math.Round(tipAmount, 2) + ".");
Console.WriteLine("The total amount is $" + Math.Round(totalAmount,2) + ".");

Console.ReadKey();
