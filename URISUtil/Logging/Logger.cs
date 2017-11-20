using System;
using System.Configuration;
using System.Diagnostics;
using System.Web;

namespace URISUtil.Logging
{
    public static class Logger
    {

        public static void WriteLog(Exception exception)
        {
            WriteLog(exception.ToString());
        }

        public static void WriteLog(string logMessage)
        {
            if (HttpContext.Current == null)
            {
                return;
            }

            StackTrace stackTrace = new StackTrace();
            StackFrame stackFrame = stackTrace.GetFrame(1);
            string typeName = stackFrame.GetType().ToString();
            string methodName = stackFrame.GetMethod().ToString();
            string fileName = stackFrame.GetFileName();
            string fileLineNumber = stackFrame.GetFileLineNumber().ToString();

            string caller = String.Format("{0} - {1} ({2}, line: {3})", new string[4] { typeName, methodName, fileName, fileLineNumber });

            LogData dataToLog = new LogData()
            {
                Time = DateTime.UtcNow,
                ServiceName = ConfigurationManager.AppSettings["ServiceName"],
                Caller = caller,
                Message = logMessage
            };

            Debug.WriteLine(dataToLog);
        }
    }
}
