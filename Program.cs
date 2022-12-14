Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
Console.WriteLine("Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.");
Console.WriteLine("При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами");
Console.WriteLine();
Console.Write("Введите элементы массива через пробел и нажмите Enter: ");
string[] arr = (Console.ReadLine().Split()); //чтение с консоли стоки, разделителем которой является пробел
Console.WriteLine();
//var str = string.Join(" ", arr); //присваивание данным введеным в строке массиву str
//Console.WriteLine(str);
string[] FindNewArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Искомых данных нет");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}
void PrintMessage(string[] array)
{
    Console.WriteLine("Исходный массив: ");
    PrintArray(array);
    Console.WriteLine();
    string[] newArray = FindNewArray(array);
    Console.WriteLine("Искомый массив: ");
    PrintArray(newArray);
    Console.WriteLine();
}
PrintMessage(arr);