Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.");
Console.WriteLine("Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.");
Console.WriteLine("При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами");
Console.WriteLine();
Console.Write("Введите элементы массива через пробел и нажмите Enter: ");
string[] arr = (Console.ReadLine().Split());
Console.WriteLine();
var str = string.Join(" ", arr);


Console.WriteLine(str);