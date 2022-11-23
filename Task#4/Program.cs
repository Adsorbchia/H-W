//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел;
Console.WriteLine("Введите первое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a>=b)&(a>c))
{
   Console.WriteLine("max" + "=" + a);
 
}
else if ((b>a) &(b>=c))

{
    Console.WriteLine("max" + "=" + b);
}
 else if ((c>=a)&(b<c))

{
    Console.WriteLine("max" + "=" + c);

 }
 else if ((a==b) & (a==c))
{
    Console.WriteLine("Все числа равны, максимального значения нет ");
}

