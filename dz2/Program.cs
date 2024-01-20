// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. 

// Пример  
// 4 3 1  =>  4 6 2  
// 2 6 9  =>  2 6 9  
// 4 6 2  =>  4 3 1  

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
}

// Изменение строк двумерного массива (первую на последнюю)

int [,] Change2DArray (int [,] array){
    int [] tempArray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++){
        tempArray[i] = array[0, i];
        array[0, i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = tempArray[i];
    }
    return array;
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
Change2DArray(array);
Console.WriteLine();
Show2DArray(array);
