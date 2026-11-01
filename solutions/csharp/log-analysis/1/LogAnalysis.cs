public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str1,string str2)
    {
        int index = str1.IndexOf(str2);
        int start = index + str2.Length;
        Console.WriteLine(str1.Substring(start));
        return str1.Substring(start); 
    }
    public static string SubstringBetween(this string str1,string str2,string str3)
    {
        int a = str1.IndexOf(str2);
        int b = str1.IndexOf(str3);
        int start = a + str2.Length;
        Console.WriteLine(str1.Substring(start,b-start));
        return str1.Substring(start,b-start); 
    }
    public static string Message(this string str1)
    {
        int index = str1.IndexOf(": ");
        Console.WriteLine(str1.Substring(index + 2));
        return str1.Substring(index + 2); 
    }
    public static string LogLevel(this string str1)
    {
        int index1 = str1.IndexOf("[");
        int index2 = str1.IndexOf("]");
        Console.WriteLine(str1.Substring(index1 + 1, index2 - index1 - 1 ));
        return str1.Substring(index1 + 1, index2 - index1 - 1 ); 
    }
}