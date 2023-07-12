int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AK(int m,int n =0)
{
if (m == 0) return n + 1;
        if (n == 0) return AK(m - 1, 1);
        return AK(m - 1, AK(m, n- 1));
}
int m = ReadInt("введите число");
int n = ReadInt("введите число");

 Console.WriteLine(AK(m, n));
        
