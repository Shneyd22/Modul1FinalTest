// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] array = new string[] { "Moscow", "Kazan", "Ufa", "Yar" };
string[] newarray = new string[NewArrayElemQuantity(array)];
FillNewArray(array, newarray);
PrintArray(newarray);




int NewArrayElemQuantity(string[] array)
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3) count++;
    }
    return count;
}


void FillNewArray(string[] array, string[] newarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[count] = array[i];
            count++;
        }
    }
}



void PrintArray(string[] array)
{
    foreach (string item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}