using XFitness.Shared.Services.Contacts;

namespace XFitness.Shared.Services;

public class LoggerToFile : ILoggerToFile
{
    public void LogToFile(string message, string filePath) 
    {
        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, message);
        }
        else 
        {
            using (StreamWriter sw = File.CreateText(filePath));
            File.WriteAllText(filePath, message);
        }
    }
}
