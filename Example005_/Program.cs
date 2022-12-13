Console.Write("Write your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
   Console.WriteLine("You are lucky Masha");     
}
 else
{
    Console.Write ("You are not lucky ");
    Console.Write(username);
 }