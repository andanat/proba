Console.Write("a=");
string input1 = Console.ReadLine();
int numberA=Convert.ToInt32(input1);
Console.Write("b=");
string input2 = Console.ReadLine();
int numberB=Convert.ToInt32(input2);
if (numberA>numberB)
{
    Console.WriteLine("max=" + numberA);
}
else
{
    Console.WriteLine("max=" + numberB);
}

