int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    // for (int i = 0; i < array.Length; i++)
    //     Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void sum2(int [] array)
{
    int sumD = 0;
    foreach (int el in array)
    {
        if (el%2==0) sumD += 1; // SumP=SumP+el
    }
    Console.WriteLine(sumD);
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
sum2(array);