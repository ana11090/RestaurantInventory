using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class Logger
    {
        static readonly string _filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RestaurantInventoryErrors.txt");
        public static async Task LogError(string method, Exception ex)
        {
            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {method} | {ex.GetType().Name} | {ex.Message}";

            using (StreamWriter sw = File.AppendText(_filePath))
            {
                await sw.WriteLineAsync(line);
            }
        }
    }
}

