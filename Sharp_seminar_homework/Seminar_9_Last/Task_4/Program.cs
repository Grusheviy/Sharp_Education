// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B 
// с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



int POW(int n, int m)
{
    int exp = 1;
    if(m == 0)
    {
        return exp;
    }
    return exp = n * POW(n, m - 1);
}

Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Write POW: ");
int m = Convert.ToInt32(Console.ReadLine());

int exp = POW(m, n);

Console.WriteLine(exp);