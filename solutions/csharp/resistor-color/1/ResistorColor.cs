public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        for(int i = 0; i < Colors().Length; i++)
        {
            if(color == Colors()[i])
            {
                return i;
            }
        }
        return -1;
    }

    public static string[] Colors()
    {
       return new string[]{"black","brown","red","orange","yellow","green","blue","violet","grey","white"};
    }
}