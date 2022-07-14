//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int Extract(int n1)
{
int sot = n1 / 100; 
int dec = n1 / 10;
int number = dec - (sot * 10);
return number;
}

int num = Extract(n1);
Console.WriteLine(num + " вторая цифра числа " + n1);*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

void ExtractFalse(int n1)
{
    if (n1 < 99)
    {
    Console.WriteLine("Третьей цифры нет");
    }
    else
    {
    int ed = n1 / 10;
    int dec = n1 / 100;
    int num = ed - dec * 10;
    Console.WriteLine("Третья цифра " + num);
    }
}

ExtractFalse(n1);
