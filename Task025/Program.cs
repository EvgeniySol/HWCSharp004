Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
int ExponentXY(int x, int y)
{
    int sum = 1;
    for(int i = 1; i <= y; i++)
    {
        int a = 0;
        a = sum*x;
        sum = a;
    }
    return sum;
}


Console.WriteLine(ExponentXY(x, y));
