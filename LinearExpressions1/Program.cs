double a, b, c, d;
Console.WriteLine("Enter a number (a) of type double: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter a number (b) of type double: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter a number (c) of type double: ");
c = double.Parse(Console.ReadLine());
Console.WriteLine("Enter a number (d) of type double: ");
d = double.Parse(Console.ReadLine());
double x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a * a / (b * b);
Console.WriteLine("x = "); Console.Write(x);
Console.Write(x);

