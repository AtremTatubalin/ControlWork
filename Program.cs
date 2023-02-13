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
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arrayResult[i];
            }
            array[count - 1] = word;
            arrayResult = array;
        }
    } while (word != "");
}

