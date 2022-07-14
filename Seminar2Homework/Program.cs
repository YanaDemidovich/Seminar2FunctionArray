//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int Extract(int n1)
{
int sot = n1 / 100; 
int dec = n1 / 10;
int number = dec - (sot * 10);
return number;
}

int num = Extract(n1);
Console.WriteLine(num + " вторая цифра числа " + n1);