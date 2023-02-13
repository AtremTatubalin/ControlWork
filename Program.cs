Console.Clear();

string[] UserArray()
{
    int count = 0;
    string word;
    string[] array;
    string[] arrayResult = new string[count];
    Console.Write("Введите элементы массива поочередно, если вы закончили, введите пустую строку: ");
    do
    {
        word = Console.ReadLine();
        if (word != "")
        {
            count++;
            array = new string[count];
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = arrayResult[i];
            }
            array[count - 1] = word;
            arrayResult = array;
        }
    } while (word != "");
    return arrayResult;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if(i < array.Length-1) Console.Write(", ");
        else Console.Write("]");
    }
}

string[] NewArray(string[] array)
{
    int count = 0;
    int count1 = 0;
    string s = "";
    for (int i = 0; i < array.Length; i++)
    {
        s = array[i];
        if(s.Length <= 3) count++;
    }
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        s = array[i];
        if(s.Length <= 3) result[count1] = s; count1++;
    }
    return result;
}

string[] userArray = UserArray();
string[] newArray = NewArray(userArray);

if(newArray.Length == 0) Console.WriteLine("[]");
else PrintArray(newArray);