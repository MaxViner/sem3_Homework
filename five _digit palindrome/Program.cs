string Palindrome ( int x)
{
    Console.WriteLine("Checking for a palindrome ");
    string symbol = " ";
    string answer = " ";
    bool check = true;
    int lef =0 ;
    int rig = 0;
    int i = 0;
    int m = 5;
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
    Console.Write("enter a five-digit integer N= ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x < 10000 || x >=100000) Console.Write("enter a five-digit integer");
    else
    {
        string rez = Palindrome (x);
        Console.Write(rez);
    }
}
catch
{
    Console.Write("enter a five-digit integer");
}

