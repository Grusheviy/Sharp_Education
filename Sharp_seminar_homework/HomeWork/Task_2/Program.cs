Console.Write("Write first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Write second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.Write("First number = " + a + Environment.NewLine + "Second number = " + b + Environment.NewLine +  a + " > " + b);
}
else
{
    Console.Write("First number = " + a + Environment.NewLine + "Second number = " + b + Environment.NewLine +  b + " > " + a);
}