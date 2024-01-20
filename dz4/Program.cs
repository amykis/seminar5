// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива. Под удалением понимается 
// создание нового двумерного массива без строки и столбца

// |4 3 1| => |2 6|
// |2 6 9| => |4 6|
// |4 6 2|

// Создание двумерного массива

int[,] Create2DArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

// Вывод в консоль двумерного массива

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Удаление строки и столбца двумерного массива, на пересечении которых расположен наименьший элемент

int[,] Min2DElement(int [,] array){
    int [,] newArrey = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    int minElement = array[0, 0];
    int rowMin = 0;
    int colMin = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (minElement > array[i, j]){
                minElement = array[i,j];
                rowMin = i;
                colMin = j;
            }
        }
    }
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if (minElement == array[i, j]){
                count += 1;
            }
        }
    }
    if (count > 1){
        Console.Write($"В массиве несколько элементов с минимальным значением {minElement} ");
        Console.WriteLine();
    } else {
        Console.WriteLine($"Значение минимального элемента - {minElement}, индекс элемента - ({rowMin}, {colMin})");
        Console.WriteLine();
        int k = 0;
        int l = 0;        
        for (int i = 0; i < array.GetLength(0); i++){
            if (i != rowMin){
                for (int j = 0; j < array.GetLength(1); j++){
                    if (j != colMin){
                    newArrey[k, l] = array[i, j];
                    l++;
                    }
                }
                l = 0;
                k++;
            }
        }
    }    
    return newArrey;
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

int[,] array = Create2DArray(row, col, min, max);

Show2DArray(array);
int [,] newArray = Min2DElement(array);
Show2DArray(newArray);