Console.WriteLine("Введите количество чисел:");
int l = Convert.ToInt32( Console.ReadLine());
double [] array = new double [l];

FillArray(array);
PrintArray(array);
PosNum(array);
Console.WriteLine("Количество положительных чисел: " + PosNum(array));

void FillArray(double [] array)
    {
    for (int i = 0; i < l; i++)
        {
        Console.WriteLine($"Введите {i+1} число:");
        double num = Convert.ToDouble( Console.ReadLine());
        array[i] = num;
        }
    }

void PrintArray(double [] array)
    {
    foreach(double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
    }

int PosNum(double [] array)
    {
    int n = 0;
    foreach(double el in array)
        if (el >= 0)
            n++;
    return n;
    }
    