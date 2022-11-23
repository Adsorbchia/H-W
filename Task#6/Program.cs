// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num%2;
if (a==0)
{
   Console.WriteLine(num +"-число четное"); 
}
else
{
    Console.WriteLine(num + "- число нечетное");
}
