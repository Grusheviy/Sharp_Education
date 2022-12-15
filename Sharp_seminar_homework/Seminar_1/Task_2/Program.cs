Console.Write("write day number: ");
int date = Convert.ToInt32(Console.ReadLine());

if(date == 1)
{
   Console.WriteLine("Mo");     
}
else if(date == 2)
{
   Console.WriteLine("Th");     
}
else if(date == 3)
{
   Console.WriteLine("Fr");     
}
else if(date == 4)
{
   Console.WriteLine("Sa");     
}
else{
    Console.WriteLine("you write not day number");     
}

// Console.Write("Введине число от 1 до 7: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 8)
// {
//    switch (number)
//   {
//     case (1):
//     Console.WriteLine("Понедельник");
//       break;
//     case (2):
//     Console.WriteLine("Вторник");
//       break;
//       case (3):
//     Console.WriteLine("Среда");
//     break;
//       case (4):
//     Console.WriteLine("Четверг");
//     break;
//       case (5):
//     Console.WriteLine("Пятница");
//     break;
//       case (6):
//     Console.WriteLine("Суббота");
//     break;
//       case (7):
//     Console.WriteLine("Воскресенье");
//     break;
//   }
// }
// else
// {
//   Console.WriteLine("Неккоректное число");
// }
