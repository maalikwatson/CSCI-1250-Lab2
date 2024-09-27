Console.WriteLine("***** Welcome to Shelter Cats App *****");
Console.WriteLine("\n");

Console.WriteLine("Please enter total number of female cats: ");
int femaleCats = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter total number of male cats: ");
int maleCats = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("**************************** \n");

// (value/total value)×100%
int totalCats = femaleCats + maleCats;

// decimal value of percentage
decimal decimalValue1 = (decimal)femaleCats / (decimal)totalCats;
decimal decimalValue2 = (decimal)maleCats / (decimal)totalCats;

// percentage value of cats
decimal percentageValue1 = (decimal)femaleCats / (decimal)totalCats * 100;
decimal percentageValue2 = (decimal)maleCats / (decimal)totalCats * 100;

// percentage value no decimals
decimal percentNoDecimal1 = (decimal)femaleCats / (decimal)totalCats * 100;
decimal percentNoDecimal2 = (decimal)maleCats / (decimal)totalCats * 100;

// rounding percentage to two decimal places
decimal percentRoundHund1 = (decimal)femaleCats / (decimal)totalCats * 100;
decimal percentRoundHund2 = (decimal)maleCats / (decimal)totalCats * 100;

// print results to console
Console.WriteLine($"DECIMAL VALUE -- Female: {decimalValue1} |  Male: {decimalValue2}");
Console.WriteLine($"PERCENT VALUE -- Female: {percentageValue1}% |  Male: {percentageValue2}%");
Console.WriteLine("PERCENT VALUE (no decimal) -- Female: " + Decimal.Floor(percentNoDecimal1) + "%  |  Male: " + Decimal.Floor(percentNoDecimal2) + "%");
Console.WriteLine("PERCENT VALUE (rounded two decimal places) -- Female " + Math.Round(percentRoundHund1, 2) + "%  |  " + "Male: " + Math.Round(percentRoundHund2, 2) + "%");
Console.WriteLine("PERCENT VALUE (rounded one decimal place) -- Female " + Math.Round(percentRoundHund1, 1) + "%  |  " + "Male: " + Math.Round(percentRoundHund2, 1) + "%");



Console.ReadKey();