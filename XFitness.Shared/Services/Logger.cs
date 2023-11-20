using XFitness.Shared.Services.Contracts;

namespace XFitness.Shared.Service;

public class Logger : ILogger
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
