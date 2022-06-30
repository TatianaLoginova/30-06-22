// See https://aka.ms/new-console-template for more information
int a, b, c;

Console.Write("Введите певое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());


if(a > b & a > c ) 
{
    Console.Write("Максимальное число " + a);
} ;

if(b > a & b > c)
{
    Console.Write("Максимальное число " + b);
} ;

if(c > a & c > b)
{
    Console.Write("Максимальное число " + c);
} ;




