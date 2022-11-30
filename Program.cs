//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Вводим первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Вводим второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Вводим третье число: ");
int c = int.Parse(Console.ReadLine()!);
 int max = a;
if(b>max)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine(+max);