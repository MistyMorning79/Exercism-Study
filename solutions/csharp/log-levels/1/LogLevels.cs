static class LogLine
{
    public static string Message(string logLine)
    {
        var index = logLine.IndexOf("]: ");
        return logLine.Substring(index + 3).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');
        string level = logLine.Substring(start, end - start);
        return level.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string msg = Message(logLine);
        string level = LogLevel(logLine);
        return $"{msg} ({level})";
    }
}
