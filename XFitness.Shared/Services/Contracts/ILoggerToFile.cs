namespace XFitness.Shared.Services.Contracts
{
    public interface ILoggerToFile
    {
        void LogToFile(string message, string filePath);
    }
}
