// Задача1. Написать программу, которая выводит случайное число из отрезка от 10 до 99 и показывает наибольшую цифру числа.

int FineBiggerDigit()
{
    int rand = new Random().Next(10, 100);
    Console.WriteLine("Current random number is " + rand);

    int dec = rand / 10;
    int ed = rand % 10;

    if (dec > ed) return dec;
    else return ed;
}

int maxNum = FineBiggerDigit();
Console.WriteLine("Bigger digit is " + maxNum);


