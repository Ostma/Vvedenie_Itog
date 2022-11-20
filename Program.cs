// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых меньше либо равна трем символам



void PrintArray(string[] array) //метод вывода на консоль заданного массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


Console.WriteLine("Сколько строк будем вводить?"); //Задаем массив и заполняем его
int lengthArray = int.Parse(Console.ReadLine() ?? "");
string[] inputArray = new string[lengthArray];

for (int i = 0; i < lengthArray; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент массива");
    inputArray[i] = Console.ReadLine();
}

Console.Clear(); //Выводим в консоль введенный массив
Console.WriteLine("Введенный массив:");
PrintArray(inputArray);

int indexStringArray = 0; //Обрабатываем введенный массив
int indexResultArray = 0;
string[] resultArray = new string[inputArray.Length];
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[indexStringArray].Length < 4)
    {
        resultArray[indexResultArray] = inputArray[indexStringArray]; // Заполняем новый массив нужными значениями
        indexResultArray++;
    }
    indexStringArray++;
}

Array.Resize(ref resultArray, indexResultArray); //"Обрезаем" пустые строки в новом массиве
Console.WriteLine(""); // ...и выводим его на печать
Console.WriteLine("Итоговый массив:");
PrintArray(resultArray);