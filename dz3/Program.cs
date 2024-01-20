// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Пример
// 4 3 1 => Строка с индексом 0
// 2 6 9
// 4 6 2

// Создание двумерного массива

int [,] Create2DArray(int row, int col, int min, int max){
    int [,] array = new int [row, col];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            array [i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

// Вывод в консоль двумерного массива

void Show2DArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Нахождение построчной суммы элементовмассива

int [] TempSummArray (int [,] array){
    int [] tempSummArray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j =0; j < array.GetLength(1); j++){
            tempSummArray[i] += array[i, j];
            }
    }
    return tempSummArray;
}

// Вывод в консоль временного массива (не обязательно)

void ShowArray(int [] array){
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Проверка наименьшей суммы в двумерном массиве (суммы строк лежат во временном массиве)

void MinSumOfElement(int [] array){
    int minIndex = 0;
    int minSumm = array[0];
    for (int i = 0; i < array.Length; i++){
        if (minSumm > array[i]){
            minIndex = i;
        }
    }
    Console.WriteLine();
    Console.Write($"Минимальная сумма элементов в строке с индексом {minIndex}");
}

Console.Clear();
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2DArray(row, col, min, max);

Show2DArray(array);

int [] tempSummArray = TempSummArray(array);

ShowArray(tempSummArray);

MinSumOfElement(tempSummArray);

