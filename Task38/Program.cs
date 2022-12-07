int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-99, 100);
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
int n = 0;
int sum(int[] array)
{
    int max =array[0];
   int min = array[0];
    for (int i = 0; i<array.Length; i++)
    {
        
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i]<min)
        {
            min = array[i];
        }
    }
    if (min<0)
    {
 n = max + min;
    }
    else
    {
        n = max - min;
    }

return n;

}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
sum(array);
Console.WriteLine(n);