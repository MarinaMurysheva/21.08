// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine ("Введите число 1");
int number1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число 2");
int number2= Convert.ToInt32 (Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("первое число больше второго");
}
    
if (number2 > number1)
{
    Console.WriteLine("второе число больше первого");
}