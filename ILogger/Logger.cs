namespace ILogger
{
    public class FileLogger : _ILogger
    {
        private string PATH = Directory.GetCurrentDirectory();
        private const string DATE_FORMAT_ASC = "yyyy-MM-dd";
        private const string TIME_FORMAT_ASC = "HH-mm-ss";
        private string _logFilePath;
        public FileLogger()
        {
            PATH = PATH.Replace(@"Selenium_WikiParser\bin\Debug\net6.0-windows", "");
            string logFolder_path = Path.Combine(PATH, "Log_", DateTime.Now.ToString(DATE_FORMAT_ASC));

            Directory.CreateDirectory(logFolder_path);


            var logFileName = DateTime.Now.ToString(TIME_FORMAT_ASC) + ".txt";
            _logFilePath = Path.Combine(logFolder_path, logFileName);
        }
        public void Log(string message)
        {
            using (StreamWriter sw = File.AppendText(_logFilePath))
            {
                sw.WriteLine($"[{DateTime.Now.ToString(TIME_FORMAT_ASC)}(" + message + ")");

            }
        }
    }
}