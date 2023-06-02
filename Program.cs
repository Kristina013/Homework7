//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double [,] Create2dArray () 
{
    Console.WriteLine("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input minimum: ");
    int minVal = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input maximum: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double [,] created2Array = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return created2Array;
}

void PrintArray(double [,] array2d) 
{
    for (int i = 0; i < array2d.GetLength(0); i++) 
    {
        for (int j = 0; j < array2d.GetLength(1); j++) 
        {
            Console.Write (array2d [i,j] + " ");  
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

double [,] new2darray = Create2dArray();
PrintArray(new2darray);

*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
// запросить у пользователя 2 величины: номер строки и номер столбца. и вывести значение из массива на этом индексе

/*

int [,] Create2dArray () 
{
    Console.WriteLine("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input minimum: ");
    int minVal = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input maximum: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,] created2Array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return created2Array;
}

void PrintArray(int [,] array2d) 
{
    for (int i = 0; i < array2d.GetLength(0); i++) 
    {
        for (int j = 0; j < array2d.GetLength(1); j++) 
        {
            Console.Write (array2d [i,j] + " ");  
        }
        Console.WriteLine();  
    }
    Console.WriteLine(); 
}

int [,] new2darray = Create2dArray();
PrintArray(new2darray);


int Element (int [,] newarray, int rows, int columns)
{
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            if (rows == i && columns == j)
                {
                    int elementOfArray = newarray [rows, columns];  
                } 
        }
    }
    return newarray[rows, columns];    
}


Console.WriteLine("Input number of row: ");
int numrow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of column: ");
int numcolumn = Convert.ToInt32(Console.ReadLine());

if(numrow >= new2darray.GetLength(0) || numcolumn >= new2darray.GetLength(1))
    {
        Console.WriteLine($"No such number in massive");
    }
else  
    {  
    int numberOfArray = Element(new2darray, numrow, numcolumn);
    Console.WriteLine($"Number on position [{numrow},{numcolumn}] is {numberOfArray}"); 
    }   

*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

 // цикл с j сначала, затем с i

/*

 int [,] Create2dArray () 
{
    Console.WriteLine("Input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input minimum: ");
    int minVal = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input maximum: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int [,] created2Array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return created2Array;
}

void PrintArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++) 
    {
        for (int j = 0; j < array2d.GetLength(1); j++) 
        {
            Console.Write (array2d [i,j] + " ");  
        }
        Console.WriteLine();  
    }
    Console.WriteLine(); 
}

void MiddleSumm(int [,] array1)
{
     for (int j = 0; j < array1.GetLength(1);j++)
    {
        double summNum = 0;
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            summNum = summNum + array1[i,j];
        }
        double middleSum = summNum / array1.GetLength(0);
        middleSum = Math.Round(middleSum, 2);
        Console.Write (middleSum + " ");
    }
}

int [,] newarray = Create2dArray();
PrintArray(newarray);
MiddleSumm(newarray);

*/