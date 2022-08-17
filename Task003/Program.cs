// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int number)
{
    int[] array = new int[number];
    for(int i = 0; i < number; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
} 

int[] CreateArray2()
{
    Console.Write("Введите количество элементов массива: ");
    int elementCount = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[elementCount];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
} 

void PrintArray(int[] array)
{
    Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if(index > 0) Console.Write(", ");
        Console.Write(array[index]);
    }
    Console.WriteLine("]");
}

PrintArray(CreateArray(8));
PrintArray(CreateArray2());

