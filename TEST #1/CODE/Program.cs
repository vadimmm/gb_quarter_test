// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
/////////////////////////////////////////////////////////////////////////////

// Массив с вводными данными
string[] arrayInput = new string[] {"hello", "2", "world", ":-)"};
// Массив для собра результатирующих данных
string[] arrayResult = new string[arrayInput.GetLength(0)];

// Число из условия задачи
int ControlLength = 3;

void DisplayStringArray(string[] array)
// Отображение не пустых строк одномерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] != null)
        {
            Console.WriteLine($"{array[i]}");
        }
    }
}

Console.WriteLine("\nВводные данные для решения задачи:");
DisplayStringArray(arrayInput);

int count = 0;
for (int i = 0; i < arrayInput.GetLength(0); i++)
{
    if (arrayInput[i].Length <= ControlLength)
    {
        arrayResult[count] = arrayInput[i];
        count++;
    }
    else
    {
        continue;
    }
}

Console.WriteLine("\nОТВЕТ: Значения добавленные во второй массив:");
DisplayStringArray(arrayResult);