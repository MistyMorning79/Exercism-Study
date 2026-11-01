public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string st1 = "212";
        string st2 = "555";
        string f1 = phoneNumber.Substring(0,3);
        Console.WriteLine(f1);
        string f2 = phoneNumber.Substring(4,3);
        Console.WriteLine(f2);
        string f3 = phoneNumber.Substring(8,4);
        Console.WriteLine(f3);
        return (f1 == st1,f2 == st2,f3);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)=>phoneNumberInfo.IsFake;
   
}
