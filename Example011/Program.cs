int [] arr = {1, 5, 4, 2, 5, 7, 9};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length  - 1; i++)
    {
        int minPosition = i;
//ищем максимальный элемент
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            minPosition = j;
        } 
// делаем свап элементов
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr); 
SelectionSort(arr);

PrintArray(arr); 