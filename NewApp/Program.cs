// See https://aka.ms/new-console-template for more information



int a,b;
System.Console.Write("a = ");
a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("b = ");
b = Convert.ToInt32(Console.ReadLine());
if ( a < b)
{
   Console.WriteLine(" a nhỏ hơn b");
}
else if (a > b)
{
  Console.WriteLine(" a lớn hơn b");  
}
else if (a == b)
{
 Console.WriteLine(" a bằng b");  
}   