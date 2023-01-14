// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int  Count(int number)
{
    int count;
    int Sum = 0;    
    for (count = 0; number > 0; count ++)
    {
    Sum += number % 10;
    number /=10;
    }
     return Sum;
}
Console.WriteLine("Write your number: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = Count(n);
Console.WriteLine($"your number Sum: {count}");  
