//Input
//The input begins with the number t of test cases in a single line (t<=10). 
//In each of the next t lines there are two numbers m and n (1 <= m <= n <= 1000000000, n-m<=100000) separated by a space.

//Output
//For every test case print all prime numbers p such that m <= p <= n, one number per line, test cases separated by an empty line.


static int[,] getData()
{
    int count = Convert.ToInt32(Console.ReadLine());
    int[,] data = new int[count,2];
    for (int i = 0; i < count; i++)
    {
        string line = Console.ReadLine();
        string[] tmp = line.Split(' ');
        data[i, 0] = Convert.ToInt32(tmp[0]);
        data[i, 1] = Convert.ToInt32(tmp[1]);
    }
    return data;
}

static bool IsPrime(int x)
{
    if (x == 0 || x == 1)
    {
        return false;
    }
    if (x == 2 || x == 3)
    {
        return true;
    }
    int stop = Convert.ToInt32(Math.Sqrt(x));
    int tmp = x/2;
    while (tmp >= stop)
    {
        if (x % tmp == 0)
        {
            return false;
        }
        tmp--;
    }
    return true;
}

static void primeNumbers(int[,] data)
{
    for (int i = 0;i < data.GetLength(0);i++)
    {
        int min = data[i,0];
        int max = data[i, 1];
        for (int x = min; x <= max; x++)
        {
            if (IsPrime(x))
            {
                Console.WriteLine(x);
            }
        }
        Console.WriteLine();
    }
}


primeNumbers(getData());
