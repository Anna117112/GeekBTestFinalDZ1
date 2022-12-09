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


String[] ConvertedArr(String[] arr, int count)
{
    if (count != 0)
    {
        String s = "";

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                s += arr[i] + " ";

            }
        }

        String[] convertArr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return convertArr;
    }
    else
    {
        String[] convertArr = new String[0];
        System.Console.WriteLine("Нет строк длинна которых соответствует условию");
        return convertArr;
    }



}


String[] arr = UserArr();
PrintArray(arr);
int count = ExaminationdArr(arr);
String[] newArr = ConvertedArr(arr, count);
System.Console.WriteLine();
System.Console.WriteLine("->");
PrintArray(newArr);