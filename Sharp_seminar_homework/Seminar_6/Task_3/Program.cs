// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("Write fibonachi length: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void fibonachi(int a)
// {
// int fib1 = 0;
// Console.Write($" {fib1}");
// int fib2 = 1;
// Console.Write($" {fib2}");
// int fib = 0;
//     for(int i = 2; i < n; i++)
//     {
//         //  например для 6
//         fib = fib2 + fib1; //  0 + 1= 1; 1 + 1 = 2; 2 + 1 = 3; 3 + 2 = 5;
//         Console.Write($" {fib}");// 0 ; 1; 1; 2; 
//         fib1 = fib2; // 0 = 1; 1 = 1; 1 = 2; 2 = 3;
//         fib2 = fib; // 1 = 1; 1 = 2; 2 = 3; 3 = 5;
//     }
// }

// Console.WriteLine($"Your fibonachi numbers: ");
// fibonachi(n);



// C массивом
void Fibonacci(int a) {
int[] arr = new int[a]; 
arr[0] = 0;
arr[1] = 1;
for(int i = 2; i < a; i++) {
    arr[i] = arr[i - 2] + arr[i - 1]; 
}
System.Console.WriteLine(string.Join(" ", arr));
}

System.Console.WriteLine("Write fibonachi length: ");
int N = Convert.ToInt32(Console.ReadLine()); 
Fibonacci(N);