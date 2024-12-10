using System;
using System.IO;

namespace MediCore.Logger
{
    /// <summary>
    /// For development purposes, you can log everything to various level, everything get logged into a file
    /// AS IT IS A DEVELOPPMENT PURPOSE, IT WILL CRASH IF YOU TRY SIMULTANEOUS TASKS ! (j'avais la flemme de rendre l'accès au fichier asynchrone)
    /// </summary>
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
        private readonly string _logFilePath;

        // Constructeur privé pour éviter que d'autres instances soient créées
        private Logger()
        {
            // Chemin du fichier de log
            _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");

            // Créer le fichier de log si n'existe pas
            if (!File.Exists(_logFilePath))
            {
                File.Create(_logFilePath).Dispose();
            }
        }

        public static Logger Instance => _instance.Value;

        public void Log(string message, LogLevel level)
        {
            // Format de la ligne de log
            var logLine = $"{getLevel(level)} {DateTime.Now}: {level}: {message}";

            // Log dans le fichier
            File.AppendAllText(_logFilePath, logLine + Environment.NewLine);

            // Log dans la console avec la couleur appropriée
            Console.ForegroundColor = GetConsoleColor(level);
            Console.WriteLine(logLine);
            Console.ResetColor();
        }

        /// <summary>
        /// COLORS, WHAT ELSE THERE IS TO SAY, I LIKE IT WHEN IT'S BEAUTIFUL OK ?
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        private ConsoleColor GetConsoleColor(LogLevel level)
        {
            return level switch
            {
                LogLevel.Debug => ConsoleColor.Gray,
                LogLevel.Info => ConsoleColor.White,
                LogLevel.Warning => ConsoleColor.Yellow,
                LogLevel.Error => ConsoleColor.Red,
                _ => ConsoleColor.White
            };
        }

        /// <summary>
        /// Different levels of logs
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        private string getLevel(LogLevel level)
        {
            return level switch
            {
                LogLevel.Debug => "[DEBUG]",
                LogLevel.Info => "[INFO]",
                LogLevel.Warning => "[WARNING ",
                LogLevel.Error => "[ERROR]",
                _ => "[?]"
            };
        }
    }

}
