try
{
    Console.Write("Введите n:");
    long n = long.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double s = 0;
    double y = 1;
    double z;
    for (long i = 0;i < n; i++)
    {
        z = Math.Pow(x, 1 + i * 2);
        s += y*(z/f); //f-факториал
        y *= -1;
    }
    Console.WriteLine("S= "+s);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
