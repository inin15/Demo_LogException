using log4net;
using System;

namespace Demo_Log
{
    internal class Program
    {
        private static readonly ILog log =
        LogManager.GetLogger(System.Reflection.MethodBase
        .GetCurrentMethod().DeclaringType);

        private static void Main(string[] args)
        {
            try {
                
                log.Info("Hello logging world!"); 
                log.Info("Error");
                Console.WriteLine("Hit enter");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                log.Info(e.ToString());
            }
            
            
            
        }
    }
}