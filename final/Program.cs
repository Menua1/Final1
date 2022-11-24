string[] array = new string[8] {"Hi", "my", "hello", "world", "bro","resiver","project","perfect"};
string[] arr = new string[array.Length];
void SecondArray(string[] array, string[] arr)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arr[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}
SecondArray(array, arr);
PrintArray(arr);