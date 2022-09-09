float distance = 0;
float Evclid_Summ = 0;
int point1 = 0;
int point2 = 0;
try
{
    for(int i = 0;i<3;i++)
    {
            Console.WriteLine("Введите {0}-ю координату первой точки", i + 1);
            point1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите {0}-ю координату второй точки", i + 1);
            point2 = int.Parse(Console.ReadLine());
            Evclid_Summ = Evclid_Summ + (float)Math.Pow((Double)(point1-point2), 2);
    }  

    distance = (float)Math.Pow((Double)Evclid_Summ, 0.5);


    Console.WriteLine("расстояние между точками = "+distance);
}
catch
{
    Console.Write("нужно целое число");
}