// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указанние, что такого элемента нет.

// Пример  
// 4 3 1  (1, 2) => 9  
// 2 6 9

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

// Проверка выхода за пределы массива

bool ReturnArrayElement(int [,] array, int line, int column){
    if (line < array.GetLength(0)){
        if (column < array.GetLength(1)){
            return true;
        }
        return false;
    }
    return false;
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

Console.Write("Введите строку массива: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец массива: ");
int column = Convert.ToInt32(Console.ReadLine());

ReturnArrayElement(array, line, column);

if (ReturnArrayElement(array, line, column) == true){
    int number = array[line, column];
    Console.WriteLine(number);
    }
    else {
        Console.WriteLine($"Такого элемента нет.");
    }