int n = Input("Введите число: ");
int i =2;
int result = 1;
string number ="1";
while(n>=i)
{
    result= Quadro3(i);
    number = number + "," +Convert.ToString(result);
    i++;
}
Console.WriteLine(number);


int Quadro3(int a)
{
    return a * a * a;
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
