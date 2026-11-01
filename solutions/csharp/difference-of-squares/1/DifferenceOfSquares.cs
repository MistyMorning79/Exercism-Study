public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)//和平方
    {
        return ((1+max)*max/2)*((1+max)*max/2);
    }

    public static int CalculateSumOfSquares(int max)//平方和
    {
        int a = 0;
        for(int i = 1; i<=max;i++)
        {
            a = a+i*i;
        }
        return a;
    }
    public static int CalculateDifferenceOfSquares(int max)//和平方-平方和
    {
        return CalculateSquareOfSum(max)-CalculateSumOfSquares(max);
    }
}