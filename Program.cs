      //    Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
/*
Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
  
var x = (b1 - b2) / (k1 - k2);
var y = k2 * x + b2;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Две прямые пересекутся в точке: ({x};{y})");
*/


//                                      Написать программу масштабирования фигуры

/*
int[,] GetNewCords(int[] a, int[] b, int[] c, int[] d, int k)       
{
    int[,] coordinates = new int[4, 2];                                    
    for (int iArr = 0; iArr < 2; iArr++)                                  
    {
        for (int j = 0; j < 2; j++)                                 
        {
            if (iArr == j)                                            
            {
                coordinates[0, j] = a[iArr];                                 
                coordinates[1, j] = (b[iArr] - a[iArr]) * k + a[iArr];
                coordinates[2, j] = (c[iArr] - a[iArr]) * k + a[iArr];
                coordinates[3, j] = (d[iArr] - a[iArr]) * k + a[iArr];
            }
        }
    }
    return coordinates;
}

void PrintCordinates(int[,] arr, char[] point)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{point[i]} ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"({arr[i, j]}, ");
            else Console.WriteLine($"{arr[i, j]})");
        }
    }
}

int k = 4;                                                          
int[] pointA = { 5, 7 };                                            
int[] pointB = { 8, 4 };
int[] pointC = { 3, 5 };
int[] pointD = { 1, 9 };
char[] pointName = { 'A', 'B', 'C', 'D' };

Console.WriteLine();
Console.WriteLine("Координаты точек фигуры при к=4:  ");
int[,] newCords = GetNewCords(pointA, pointB, pointC, pointD, k);
PrintCordinates(newCords, pointName);
*/


//                                        Написать программу копирования массива

/*
int[] TakeArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int[] CopyArray(int[] originArray)
{
    int[] copy = new int[originArray.Length];
    for (int i = 0; i < originArray.Length; i++)
    {
        copy[i] = originArray[i];
    }
    return copy;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int size = 10;
int min = 1;
int max = 1000;

int[] origin = TakeArray(size, min, max);
Console.WriteLine("массив :");
PrintArray(origin);
Console.WriteLine();
Console.WriteLine("Копия массива :");
int[] copy = CopyArray(origin);
PrintArray(copy);
*/


