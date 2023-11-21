Console.WriteLine("Input double m:");
double m = double.Parse(Console.ReadLine());
Console.WriteLine("Input double n:");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("Input double a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Input double b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Input double x:");
double x = double.Parse(Console.ReadLine());

double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * 
    Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + m * m - m);
Console.WriteLine($"z1 = {z1}");

double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"z2 = {z2}");

double y = 2.4*Math.Abs((x*x+b)/a)+(a - b) * Math.Pow(Math.Sin((a - b) + 
    Math.Pow(10, -2) * (x - b)), 2);
Console.WriteLine($"y = {y}");