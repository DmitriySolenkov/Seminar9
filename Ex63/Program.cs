int Prompt(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int num = Prompt("Введите число N:");

string PrintNumRec(int start, int end)
{
    if (start == end) return Convert.ToString(start);
    else return (start + " " + PrintNumRec(start + 1, end));
}

Console.WriteLine(PrintNumRec(1, num));