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

void Task19()
{

}

void Task21()
{

}

void Task23()
{

}