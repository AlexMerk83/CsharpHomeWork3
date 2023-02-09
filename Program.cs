bool isWork = true;

while (isWork)
{
    Console.Clear();

    System.Console.WriteLine();
    System.Console.WriteLine("Homework 3 tasks:");
    System.Console.WriteLine("1 - Task 19: Is palindrome?");
    System.Console.WriteLine("2 - Task 21: Distance in 3D");
    System.Console.WriteLine("3 - Task 23: Table of cubes");
    System.Console.WriteLine("0 - Exit");
    System.Console.Write("Enter a task nunber: ");

    int taskNo = 0;

    if (int.TryParse(Console.ReadLine(), out taskNo))
    {
        System.Console.WriteLine();

        switch (taskNo)
        {
            case 1: Task19(); break;
            case 2: Task21(); break;
            case 3: Task23(); break;
            case 0: isWork = false; break;
            default: System.Console.WriteLine("There is no such option. Try again."); break;
        }
        
        if (isWork)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    else
    {
        System.Console.WriteLine();
        System.Console.WriteLine("There is no such option. Try again.");

        System.Console.WriteLine();
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

}

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void Task19()
{

}

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void Task21()
{
    Console.Clear();
    Console.WriteLine("Enter coordinates (X, Y, Z) of Point A");

    int x1 = ReadInt("X: ");
    int y1 = ReadInt("Y: ");
    int z1 = ReadInt("Z: ");

    System.Console.WriteLine();
    Console.WriteLine("Enter coordinates (X, Y, Z) of Point B");

    int x2 = ReadInt("X: ");
    int y2 = ReadInt("Y: ");
    int z2 = ReadInt("Z: ");

    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

    System.Console.WriteLine();
    System.Console.WriteLine($"The distance between ({x1},{y1},{z1}) and ({x2},{y2},{z2}) equals {Math.Round(dist,2)})");
}

int ReadInt(string msg)
{
    int res = 0;
    
    System.Console.Write(msg);

    while (!int.TryParse(Console.ReadLine(), out res))
    {
        System.Console.WriteLine("Input error. Enter an integer number.");
        System.Console.Write(msg);
    }

    return res;
}


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void Task23()
{

}