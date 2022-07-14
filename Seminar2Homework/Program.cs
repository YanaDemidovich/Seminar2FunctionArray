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

/*int n1 = new Random().Next(1000, 10000); // честно признаюсь, это уловка)))
Console.WriteLine("Случайное число " + n1);

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

ExtractFalse(n1);*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

