string[] array1 = new string[5] {"324582", "mat", "mortol", "NBA", "clocs"};
string[] array2 = new string[array1.Length];
void ArrayWitchiw(string[] array1, string[] array2)
{
    int caunt = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[caunt] = array1[i];
        caunt++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayWitchiw(array1, array2);
PrintArray(array2);