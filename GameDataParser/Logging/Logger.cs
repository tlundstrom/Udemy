public class Logger
{
    private readonly string _logFileName;

    public Logger(string logFileName)
    {
       _logFileName = logFileName;
    }

    public void Log(Exception e)
    {
        var entry =
$@"[{DateTime.Now}]
Exception message: {e.Message}
Stack trace: {e.StackTrace}

";
        File.AppendAllText(_logFileName, entry);
    }
}