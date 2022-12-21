// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

//Через условия if else (рабочая)
// Console.Write("Write you day of week number: ");
// int day_numb = Convert.ToInt32(Console.ReadLine());

// if(day_numb >= 6 && day_numb <= 7)
// {
//     Console.Write("Weekend");
// }
// else if(day_numb > 0 && day_numb < 6)
// {
//     Console.Write("Not weekend");
// }
// else
// {
//     Console.Write("You write wrong day of week number");
// }


// Через switch/case
Console.Write("Write you day of week number: ");
int day_numb = Convert.ToInt32(Console.ReadLine());
switch (day_numb)
{
   case 1:
      Console.WriteLine("Not weekend, its Monday");
   break;
   case 2:
      Console.WriteLine("Not weekend, its Tuesday");
   break;
   case 3:
      Console.WriteLine("Not weekend, its Wednesday");
   break;
   case 4:
      Console.WriteLine("Not weekend, its Thursday");
   break;
   case 5:
      Console.WriteLine("Not weekend, its Friday");
   break;
   case 6:
      Console.WriteLine("Weekend, its Saturday");
   break;
   case 7:
      Console.WriteLine("Weekend, its Sunday");
   break;
   default:
      Console.WriteLine("You write wrong day of week number");
   break;
}