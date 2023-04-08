Console.WriteLine("Введиете число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиете число N");
int N = Convert.ToInt32(Console.ReadLine());
if (N>M)
{
    

if(M>0 && N>0)
{
int sum(int M,int N)
{
   if (N == M)
   {
    return N;
   }
   return M + sum(M+1,N);
}
Console.WriteLine($"Результат {sum(M,N)}");
}
else
 Console.Write("Не натуральное число ");
}
else
Console.WriteLine("N должен быть больше M");