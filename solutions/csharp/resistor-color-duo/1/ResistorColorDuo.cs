public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        int a = 0;
        int b = 0;
        string[] _colors = new string[]{"black","brown","red","orange","yellow","green","blue","violet","grey","white"};
        for(int i = 0; i < _colors.Length; i++)
        {
            if(colors[0] == _colors[i])
            {
                a=i;
            }
            if(colors[1] == _colors[i])
            {
                b=i;
            }
        }
        return a*10+b;
    }
}
