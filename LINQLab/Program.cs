int[] nums = new int[]
{
    10,
    2330,
    112233,
    12,
    949,
    3764,
    2942,
    523863
};

//Write code using Linq to answer the following questions: 

//Find the Minimum value 
var minimumValue = nums.Min();

Console.Write($"Minimum value: {minimumValue}");


//Find the Maximum value
var maximumValue = nums.Max();

Console.Write($"\nMaximum value: {maximumValue}");


//Find the Maximum value less than 10000
var maximumUnder10000 = nums.Where(x => x < 10000).Max();

Console.Write($"\nMaximum value less than 10000: {maximumUnder10000}");


//Find all the values between 10 and 100
var lowValuesBetween = nums.Where(x => x >= 10 && x <= 100);

Console.Write("\nValues between 10 and 100: ");
foreach (int num in lowValuesBetween)
{
    Console.Write(num + " ");
}

//Find all the Values between 100000 and 999999 inclusive 
var highValuesBetween = nums.Where(x => x >= 100000 && x <= 999999);

Console.Write("\nValues between 100000 and 999999: ");
foreach (int num in highValuesBetween)
{
    Console.Write(num + " ");
}


//Count all the even numbers
var evenNumbers = nums.Count(x => x % 2 == 0);

Console.WriteLine("\nEven numbers count: " + evenNumbers);