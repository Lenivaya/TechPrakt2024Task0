using static System.Console;

double a,
    b,
    sum;

Write("Enter a = ");
double.TryParse(ReadLine(), out a);

Write("Enter b = ");
double.TryParse(ReadLine(), out b);

sum = a + b;
WriteLine($"\nSum: {sum}");
