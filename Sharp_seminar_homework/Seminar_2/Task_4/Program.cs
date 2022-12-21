// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Vvedite chislo: ");
int a = Convert.ToInt32(Console.ReadLine());
int mod1 = a % 7;
int mod2 = a % 23;
if(mod1 == 0 && mod2 == 0)
{
Console.Write("kratno");
}
else
{
Console.Write("ne kratno ");
}