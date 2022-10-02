string[] arrayInput = new string[] {"hello", "2", "world", ":-)"};
string[] arrayResult = new string[arrayInput.GetLength(0)];
int ControlLength = 3;

void DisplayStringArray(string[] array)
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

// for (int i = 0; i < arrayResult.GetLength(0); i++)
// {
//     if (arrayResult[i] != null)
//     {
//         Console.WriteLine($"{arrayResult[i]}");
//     }
// }