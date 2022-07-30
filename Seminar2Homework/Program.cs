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

// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

void FindThirdDigit()
{
    
    int rand = new Random().Next();
    Console.WriteLine("Заданное число = " + rand);
    if (rand < 100)
    {
        Console.WriteLine("У числа нет третьей цифры");
    }
    else
    {    
        int third = 0;
        while (rand > 99)
     {
         third = rand % 10;
         rand = rand / 10;
     
     }
     Console.WriteLine("Третья цифра данного числа = " + third);    
    }
}
FindThirdDigit();

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

