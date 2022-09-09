    Console.WriteLine("сколькиМерное пространство будем считать?");
    int n = int.Parse(Console.ReadLine());
    int[] point1 = new int[n];
    int[] point2 = new int[n];
    for(int i = 0;i<n;i++)
        {
            Console.WriteLine("Введите {0}-ю координату первой точки", i + 1);
            point1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите {0}-ю координату второй точки", i + 1);
            point2[i] = int.Parse(Console.ReadLine());
        }
float Evclid_Distance(int n)
{
    float distance = 0;
    float Evclid_Summ = 0;
    for(int i = 0;i<n;i++)
    {
        Evclid_Summ = Evclid_Summ + (point1[i]*point1[i]+point2[i]*point2[i]);
        //Console.WriteLine(Evclid_Summ);
    }
    distance = (float)Math.Pow((Double)Evclid_Summ, 0.5);
    return distance;
}
try
{
    float rez;
    rez = Evclid_Distance(n);
    Console.WriteLine("расстояние между точками = "+rez);
}
catch
{
    Console.Write("нужно целое число");
}