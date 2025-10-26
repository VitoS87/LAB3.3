try
{
    Console.Write("Введите n:");
    long n = long.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double s = 0;
    double y = 1;
    double z;
    double f = 1;
    for (long i = 0; i < n; i++)
    {
        for (int j = 1; j <= 1+i*2; j++)
        {
            f *= j;
        }
        z = Math.Pow(x, 1 + i * 2);
        s += y * (z / f);
        y *= -1;
        f = 1;
    }
    Console.WriteLine("Сумма= " + s);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
