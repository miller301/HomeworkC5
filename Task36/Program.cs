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
 int sumn=0;
void sum(int[] array)
{
   
    for (int i =0; i<array.Length; i++)
    {
        if (i%2!=0)
        {
sumn=sumn+array[i];
        }
        

    }
    Console.WriteLine(sumn);
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
sum(array);