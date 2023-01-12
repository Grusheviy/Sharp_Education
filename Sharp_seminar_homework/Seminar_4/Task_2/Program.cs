
// int  Count(int number)
// {
//     int count;
//     for (count = 0; number > 0; count ++)
//     {
//         number /= 10;
//     }
//     return count;
// }

// Console.WriteLine("Write your number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = Count(N);
// Console.WriteLine($"your number lenght: {count}");

// Намного проще 


Console.WriteLine("Write your number: ");
string a = Console.ReadLine(); 
if(int.TryParse(a, out int A)) {
    Console.WriteLine(a.Length); 
} else {
    Console.WriteLine("Error");
}
