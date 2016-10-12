using System;

namespace TryLog4net
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Debug("debug");
            Logger.Info("info");
            Logger.Performance("performance");
            Logger.Exception(new Exception("exception"));
        }
    }
}