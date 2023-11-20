namespace XFitness.Shared.Services.Contracts
{
    public interface ILogger
    {
        void LogToFile(string message, string filePath);
    }
}
