int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int Y  = int.Parse(Console.ReadLine());
int startpower = N;
int countPoked = 0;

while (N >= M)
{
    N -= M;
    countPoked++;

    if  (N == startpower / 2 && Y != 0)
        {
        if (Y != 0)
        {
            N /= Y;
        }
    }


}
Console.WriteLine(N);
Console.WriteLine(countPoked);