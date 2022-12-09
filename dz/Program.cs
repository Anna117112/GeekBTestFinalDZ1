String[] UserArr()
{

    System.Console.WriteLine("Введите слова через пробед");
    String s = Console.ReadLine();
    if (s.Length != 0)
    {
        String[] arr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return arr;
    }
    else
    {
        String[] arr = new String[0];
        return arr;
    }
}
int ExaminationdArr(String[] arr)
{

    int count = 0;
    String s = "";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            s += arr[i] + " ";
            count++;
        }

    }

    return count;
}



void PrintArray(String[] array)
{

    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}