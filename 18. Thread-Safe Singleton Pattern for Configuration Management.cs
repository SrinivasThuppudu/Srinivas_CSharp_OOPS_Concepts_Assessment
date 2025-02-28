using System;

class ConfigurationManager
{
    private static ConfigurationManager? instance;
    private static readonly object lockObject = new object();

    private ConfigurationManager() { }

    public static ConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
            }
        }
        return instance;
    }
}