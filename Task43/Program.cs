//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите k1:");
double k1 = Convert.ToDouble( Console.ReadLine());

Console.WriteLine("Введите b1:");
double b1 = Convert.ToDouble( Console.ReadLine());

Console.WriteLine("Введите k2:");
double k2 = Convert.ToDouble( Console.ReadLine());

Console.WriteLine("Введите b2:");
double b2 = Convert.ToDouble( Console.ReadLine());

FindCoord (k1,b1,k2,b2);

void FindCoord (double k1, double b1, double k2, double b2)
    {
    if (k1 > k2 | k1 < k2 )
        {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения: ({x}; {y})");
        }

    if (k1 == k2 & b1 == b2 )
            Console.WriteLine("Прямые совпадают");

    if (k1 == k2 & (b1 > b2 | b1 < b2) )
        Console.WriteLine("Прямые параллельны");      
    }

