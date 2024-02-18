// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


int getSizeNewArray(string[] array)
{
    int sizeOfTheNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sizeOfTheNewArray += 1;
        }
    }
    return sizeOfTheNewArray;
}

string[] createAndFillNewArray(string[] array)
{
    string[] newArray = new string[getSizeNewArray(array)];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

Console.WriteLine("Введите строку, разделяя её символом “;” на подстроки, которые будут являться элементами первоначального массива (string 1;string 2;string 3;...;last string)");
string str = Console.ReadLine();
string[] initialArray = str.Split(';');
string[] newArray = createAndFillNewArray(initialArray);

Console.WriteLine();
Console.WriteLine($"Первоначальный массив:");
Console.WriteLine($"[“{string.Join("”, “", initialArray)}”]");

Console.WriteLine();
Console.WriteLine($"Новый массив:");
Console.WriteLine($"[“{string.Join("”, “", newArray)}”]");