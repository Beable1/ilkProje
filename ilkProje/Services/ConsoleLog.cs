using ilkProje.Services.İnterfaces;

namespace ilkProje.Services
{
    public class ConsoleLog:ILog
    {
        public ConsoleLog(int sayi) { 
        }

        public void Log()
        {
            Console.WriteLine("message");
        }
    }
}
