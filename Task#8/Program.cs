
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N // Например: 5 -> 2, 4
Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
int k=1;
while (true)
{
    if (i%2==0)
    {
        Console.Write( i +  " " );
        k++;
    }
    if (i==N)
    {
        break;
  
  }
i++;
    
}
