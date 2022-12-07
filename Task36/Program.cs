int[] CreateArray(int size)  
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)   
        Console.Write($"{el} ");
    
    Console.WriteLine();
}
 int sumn=0;
void sum(int[] array)
{
   
    for (int i =0; i<array.Length;)
    {
        int d = i%2;
        if (d==0)
        {
sumn=sumn+array[i];
i++;
        }
        else
        {
            i++;
        }
        

    }
    Console.WriteLine(sumn);
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
sum(array);