// Рабочий 
// int [] array = {1, 21, 31, 41, 81, 65, 72, 81};

// int n = array.Length;

// int find = 81;
// int index = 0;

// while(index < n)
// {
//     if(array[index] == find)
//     {
//        Console.WriteLine(index);
//        break;
//     }
//     index++;
// }



// Метод void не возвращает никаких значений
void FillArray(int [] Collection)
{
    int Length = Collection.Length;
    int index = 0;
    while(index < Length)
    {
        Collection[index] = new Random().Next(1, 10);
        index++;
    }

}
void PrintArray(int [] Col)
{
    int count = Col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(Col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    
    while(index < count)
    {
        if(collection[index] ==  find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);
