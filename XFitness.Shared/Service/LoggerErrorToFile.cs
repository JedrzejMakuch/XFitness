using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFitness.Shared.Service
{
    public class LoggerErrorToFile
    {
        public void LogToFile(string message, string filePath)
        {
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, message);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(filePath)) ;
                File.WriteAllText(filePath, message);
            }
        }
    }
}
