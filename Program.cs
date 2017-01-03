using System;

namespace netlog4net
{
    internal class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static void Main(string[] args)
        {
            log.Info("La aplicación está iniciada!");

            try
            {
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException e)
            {
                log.Fatal($"Ha ocurrido una excepción, el mensaje es el siguiente: {e.Message}");
            }

            Console.Read();
        }
    }
}