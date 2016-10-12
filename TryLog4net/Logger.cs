using System;

namespace TryLog4net
{
    public static class Logger
    {
        private static readonly log4net.ILog _performance =
            log4net.LogManager.GetLogger("PERFORMANCE");

        private static readonly log4net.ILog _info =
            log4net.LogManager.GetLogger("INFO");

        private static readonly log4net.ILog _debug =
            log4net.LogManager.GetLogger("DEBUG");

        private static readonly log4net.ILog _error =
            log4net.LogManager.GetLogger("ERROR");

        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public static void Info(string msg) => _info.Info(msg);
        public static void Debug(string msg) => _debug.Debug(msg);
        public static void Exception(Exception ex) => _error.Fatal(ex.ToString());
        public static void Performance(string msg) => _performance.Info(msg);
    }
}