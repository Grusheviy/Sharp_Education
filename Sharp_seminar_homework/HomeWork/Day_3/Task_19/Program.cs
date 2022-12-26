// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckingNumber(string numb)
{
  if (numb[0]==numb[4] && numb[1]==numb[3])
  {
    Console.WriteLine("Your number is palindrome");
  }
  else 
  {
  Console.WriteLine("Your number not palindrome");
  }
}

Console.Write("Write your five-digit number: ");
string numb = Console.ReadLine();

if (numb.Length == 5){
  CheckingNumber(numb);
}
else Console.WriteLine("Your write wrong number");