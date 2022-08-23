Console.WriteLine("Введите целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
int Sum (int x)
{
    string y = x.ToString();
    int[] array = new int[y.Length];
    int sum = 0;
    for(int i = 0; i < y.Length; i++)
    { 
        array[i] = int.Parse(y[i]+ "");
        sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine(Sum(x));
