// Задача2. Необходимо написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. 
// И как результат выводит двузначное число. 

/*int Number()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Current random number is " + rand);

    int sot = rand / 100;
    int dec = rand / 10;
    int ed = rand % 10;

    return sot * 10 + ed;
}

int num = Number();
Console.WriteLine("Result " + num); */


// Задача 3. Написать программу, которая будет принимать на вход 2 числа и выводить явлется ли второе число кратно первому. 
// Если не кратно, то выводит остаток от деление. (Делать через void).


void Multiple(double n1, double n2)
{
    if(n2 % n1 == 0)
    {
    Console.WriteLine("Числа кратные");
    }
    else
    {
    double num = n2 / n1;
    Console.WriteLine("Остаток от деления " + num);
    }
}
Console.Write("Input first number: ");
double n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
double n2 = Convert.ToInt32(Console.ReadLine());

Multiple(n1,n2);


// Задача 4. Написать программу, которая принимает на вход число и проверяет кратно ли оно 7-ми и 23-м. 
// (Делать через bool)

/*Console.Write("Input number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

void TrueFalse(int number1)
{
    if(number1 % 7 == 0 && number1 % 23 == 0)
    {
    Console.WriteLine(number1 + " кратно 7-ми и 23-м");
    }
    else
    {
    Console.WriteLine(number1 + " не кратно 7-ми и 23-м");
    }
}

TrueFalse(number1);*/
