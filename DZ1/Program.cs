int a = Input("Введи пятизначное число:");
int temp=a;
int b = 0;

while (temp !=0)
{
    b= b * 10 + temp % 10;
    temp /= 10;
}
if (a==b)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
