// Программа принимает на вход число А и выдает сумму от 1 до А
// 4 -> 10
// 8 -> 36

int Sum(int number)
{
    int sum = 0;
    for(int i = 1; i <= number; i++)
    {
        sum += i; // sum = sum + i
    }
    return sum;
}

Console.WriteLine("vvedite chislo: ");
int A = Convert.ToInt32(Console.ReadLine());
// int sum = Sum(A);
Console.WriteLine(Sum(A));


