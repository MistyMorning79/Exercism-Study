public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastTwo = number % 100;
        string suffix;

        if (lastTwo is 11 or 12 or 13)
        {
            suffix = "th";
        }
        else
        {
            int lastOne = number % 10;
            suffix = lastOne switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
        }

        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}
