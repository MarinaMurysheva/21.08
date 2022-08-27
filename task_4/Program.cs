// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int numberN = Convert.ToInt32(Console.ReadLine());
int numberM = 2;
Console.Clear();

while (numberM<=numberN)

{
    Console.WriteLine(numberM);
    numberM+=2;
}

