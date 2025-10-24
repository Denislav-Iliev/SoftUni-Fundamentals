string str = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
string result = Repeatstring(str, count);
Console.WriteLine(result);
static string Repeatstring(string str, int count)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result += str;
    }
    return result;
}