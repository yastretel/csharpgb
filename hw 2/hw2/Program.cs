int result1 = 0;

Console.Write("Введите первое число:");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");

int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");

int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    result1 = a;
}    
else
{
    result1 = b;
}

if(result1 > c)
{

    Console.WriteLine("Большее число: " + result1);

}
else
{

    Console.WriteLine("Большее число: " + c);

}