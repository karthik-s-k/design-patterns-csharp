using System;
using System.IO;
using System.Text;

namespace design_patterns_csharp
{
    public sealed class Logger
    {
        private Logger()
        {

        }

        private static StreamWriter _output = null;
        private static Logger _logger = null;
        private static readonly object lockObject = typeof(Logger);
        public static string _LogFile = "LogDetails.log"; //File will be in debug folder
        public static int _LogLevel = 1;

        public static Logger GetInstance()
        {
            //Thread Safe Using Double Check Locking
            if (_logger == null)
            {
                //lockObject - Simple Thread Safe (multi threaded environment)
                lock (lockObject)
                {
                    if (_logger == null)
                    {
                        _logger = new Logger();
                    }
                }
            }            

            return _logger;
        }

        //Thread Safe without using locking but not lazy instantiation

        //Static constructors in C# are specified to execute only when an instance of the class is created 
        //    or a static member is referenced, and execute only once per AppDomain. 
        //It is faster than the previous example because there is no locking mechanism.


        //private static readonly Logger _logger = new Logger();
        //static Logger() { }  // Static constructor added
        //private Logger() { }

        //public static Logger GetInstance()
        //{
        //    return _logger;
        //}

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

                    _output.WriteLine("Error " + " | " + DateTime.Now + " | " + severity + " | " + logMessage, new object[0]);

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

        public void logInfo(string logMessage, int severity = 1)
        {
            try
            {
                if (severity <= _LogLevel)
                {
                    if (_output == null)
                    {
                        _output = new StreamWriter(_LogFile, true, Encoding.Default);
                    }

                    _output.WriteLine("Info " + " | " + DateTime.Now + " | " + severity + " | " + logMessage, new object[0]);

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
