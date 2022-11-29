// Написать программу, которая
// из имеющегося массива строк
// формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// ПРИМЕР ["hello", "2", "world", ":-)"] -> ["2",":-)"]

int length = 3;  // Переменная означающая максимальную длину элемента массива

string[] ArrayStrings = new string[] {}; //Создаем массив и заполняем его вводом строк в консоль
Console.Write("Сколько строк Вы хотите ввести");
int number = Convert.ToInt32(Console.ReadLine());
ArrayStrings = new string[number];
for (int i = 0; i < ArrayStrings.Length; i++)
{
    Console.Write($" Введите строку: ");
    ArrayStrings[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine($"{PrintArray(ArrayStrings)}"); //выводим полученный массив в консоль
Console.WriteLine();

int MinCheckArray(string[] array, int length)  //проверяем длину элементов, сверяем с переменной созданной ранее
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) result++;
    }
    return result;
}

int numbers = MinCheckArray(ArrayStrings, length); //создаем новую переменную и присваиваем ей значение функции MinCheckArray

string[] newArrayStrings = new string[numbers]; // создаем новый массив
NewArray(ArrayStrings, newArrayStrings, length);

void NewArray(string[] finalArray, string[] newArray, int leng)
{
    int count = 0;
    for (int i = 0; i < finalArray.Length; i++)
    {
        if (finalArray[i].Length <= leng)
        {
            newArray[count] = finalArray[i];
            count++;
        }
    }
}

string PrintArray(string[] array) // функция выводв в консоль массива
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}


Console.WriteLine($" -> {PrintArray(newArrayStrings)}"); //выводим массив в консоль
