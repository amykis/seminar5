// Задача №1: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

// Создание двумерного массива

int [,] Create2DArray(int row, int col, int min, int max){
    int [,] arr = new int [row, col];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

// Вывод в консоль двумерного массива

void Show2DArray(int [,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Изменение элементов массива, у которых индексы чётные

int [,] Change2DArray (int [,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            if (i % 2 == 0 && j % 2 == 0){
                arr[i, j] *= arr[i, j];
            }
        }
    }
    return arr;
}

// Нахождение суммы элементов находящихся на главной диагонали

int SummDiag (int [,] arr){
    int sum = 0;
    int minInd = arr.GetLength(0);
    if (minInd > arr.GetLength(1)){
        minInd = arr.GetLength(1);
    }
    for (int i = 0; i < minInd; i++){
        sum += arr[i, i];
    }
    return sum;        
}

// Создание одномерного массива состоящих из средних арифметических значений по строкам двумерного массива

int [] Average2Array(int [,] arr){
    int [] array = new int [arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++){
        int average = 0;
        for (int j = 0; j < arr.GetLength(1); j++){
            average += arr[i, j];
        }
        array[i] = average/arr.GetLength(1);
    }
    return array;
} 

// Вывод одномерного массива в консоль

void ShowArray(int [] arr){
    foreach(int i in arr){
        Console.WriteLine($"{i} ");
    }
}



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

int [,] changeArray = Change2DArray(array);

Show2DArray(changeArray);

int sum = SummDiag(array);

Console.WriteLine(sum);
Console.WriteLine();

ShowArray(Average2Array(array));



// Задача №2: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной
// диагонали (с индексами (0,0); (1;1) и т.д.)



// Задача №3: Задайте двумерный массив из целых чисел.
// Сформируйте новый одномерный массив, состоящий из средних
// арифметических значений по строкам двумерного массива.