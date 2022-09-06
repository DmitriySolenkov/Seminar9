int Prompt(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int NumSum(int sum, int num)
{
    if (num < 10) return sum + num;
    else
    {
        sum+= num%10;
        return (NumSum(sum, num/10));
    }
}

int num = Prompt("Введите число:");

Console.WriteLine(NumSum(0,num));
