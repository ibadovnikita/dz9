Console.WriteLine("Введиете натуральное число ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Результат");
if (N > 0)
{
    int natchisla (int N)
    {   Console.WriteLine($"{N}");
        if (N==1)
        {
            return 1;
        }
        return natchisla(N - 1);
      
    } 
    natchisla(N);
}
else
{
  Console.Write("Не натуральное число");
}