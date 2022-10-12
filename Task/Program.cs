
// метод выбора из массива строк с длиной 3 и менее
void ArrayInArray(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[j] = array1[i];
        j++;
        }
    }
}
// печать массива строк
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array1 = new string[5] {"rtyh", "g6yhn", "tyu", "ty", "95k"};
string[] array2 = new string[array1.Length];
ArrayInArray(array1, array2);
PrintArray(array2);