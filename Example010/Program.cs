// void Method1()
// {
//     Console.Write("avtor");
// }
// Method2();

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2 ("text");

// void Method3 (string msg, int count)
// {
//     int i = 0;
//     while (i<ocunt)
//     {
//         Console.WriteLine(msg);
//         count++;
//     }
// }
// Method3(msg: "text", 4);

// Method3(count: 4, msg: "new text");

// void Method4()
// {
//     return DateTime.Now.Year;
// }
// int year = Method4();
// Console.WriteLine(year);

// void Method5(int count, string text);
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//          result = result + text;
//     }
//     return result;
// }

// string res = Method5(10, "qwerty");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

string text = "Я думаю, - сказал князь, улыбаясь, - что,"
            + "если бы вас послали вместо нашего милорда";

string replase(string text, char oldValue, char NewValue)
{
string result = string.Empty;   
int length = text.Length;
for (int i = 0; i < length; i++)
{
    if(text[i] == oldValue) result = result + $"{NewValue}";
    else result = result + $"{text[i]}";
}
return result;
}
string newText = replase(text, ' ','|');

Console.WriteLine(newText);
Console.WriteLine();
newText = replase(newText, ',','@');
Console.WriteLine(newText);