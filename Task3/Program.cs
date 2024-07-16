/////Задача 3: Задайте произвольный массив. 
///Выведете его элементы, начиная с конца. 
///Использовать рекурсию, не использовать циклы
///

void PrintArrayReverse(int[] array, int i)
{
    if (i >= 0)
    {
        Console.Write(array[i] + " ");
        PrintArrayReverse(array, i - 1);
    }
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];

Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < size; i++)
{
    myArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Элементы массива в обратном порядке:");
PrintArrayReverse(myArray, myArray.Length - 1);