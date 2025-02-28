using System;

interface ILogger
{
    void Log(string message);
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Logging to file: " + message);
    }
}

class TimestampLogger : ILogger
{
    private ILogger logger;

    public TimestampLogger(ILogger logger)
    {
        this.logger = logger;
    }

    public void Log(string message)
    {
        string timestampedMessage = DateTime.Now + " - " + message;
        logger.Log(timestampedMessage);
    }
}