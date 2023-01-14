// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int MyPow(int A, int B)
{
     int result = A;
    for(int count = 1; count < B; count++)
    {
        result *= A;
    }
    return result;
}
Console.WriteLine("Write you number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write you Pow: ");
int B = Convert.ToInt32(Console.ReadLine());
int pow = MyPow(A,B);
Console.Write($"Yor number {A} in Pow {B}: {pow}");




