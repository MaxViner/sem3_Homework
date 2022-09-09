string Palindrome (Double m)
{
    Console.Write("Checking for a palindrome ");
    //Double m = Double.Parse(Console.ReadLine());
    string symbol = " ";
    string answer = " ";
    bool check = true;
    int lef =0 ;
    int rig = 0;
    int i = 0;
    int x = new Random().Next(1, (int)Math.Pow((Double)10,m));
    Console.WriteLine(x);
    while (i < m/2)
    {   
        rig = x/(((int)Math.Pow((Double)10,(m-1-i))))%10;
        lef = x%(((int)Math.Pow((Double)10,(i+1))))/((int)Math.Pow((Double)10,(i)));
        if ( rig == lef )
        {
            symbol = "  =  ";
        }
        else
        {
            check = false;
            symbol = "  not = ";
        }
        Console.Write(rig +symbol);
        Console.WriteLine(lef); 
        i++;
    }
if (check==true)
{
    answer="Yeah!!!, This is Palindrome!";
}
else
{
    answer=" This number is not Palindrome";
}
return answer;
}
try
{
    Console.WriteLine("how many digits does a number have?");
    Double m = Double.Parse(Console.ReadLine());
    string rez = Palindrome (m);
    Console.Write(rez);
}
catch
{
    Console.Write("введите целое число");
}

