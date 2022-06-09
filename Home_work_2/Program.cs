Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if(a<b)
{
    if(b<c)
    {
        Console.WriteLine("третье большее число");
    }
    else
    {
        Console.WriteLine("второе большее число");
    }
}
else
{
    if(a<c)
    {
        Console.WriteLine("третье большее число");
    }
    else
    {
        Console.WriteLine("первое большее число");
    }
}