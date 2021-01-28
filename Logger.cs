using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_csharp
{
    class Logger
    {
        private Logger()
        {

        }

        private static StreamWriter _output = null;
        private static Logger _logger = null;
        private static object lockObject = typeof(Logger);
        public static string _LogFile = "LogDetails.log"; //File will be in debug folder
        public static int _LogLevel = 1;

        public static Logger GetInstance()
        {
            //lock object to make it thread safe (multi threaded environment)
            lock (lockObject)
            {
                if (_logger == null)
                {
                    _logger = new Logger();
                }
            }

            return _logger;
        }

        public void logError(string logMessage, int severity = 1)
        {
            try
            {
                if (severity <= _LogLevel)
                {
                    if (_output == null)
                    {
                        _output = new StreamWriter(_LogFile, true, Encoding.Default);
                    }

                    _output.WriteLine(DateTime.Now + " | " + severity + " | " + logMessage, new object[0]);

                    if (_output != null)
                    {
                        _output.Close();
                        _output = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, new object[0]);
            }
        }

        public static void closeLog()
        {
            try
            {
                if (_output != null)
                {
                    _output.Close();
                    _output = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, new object[0]);
            }
        }
    }
}
