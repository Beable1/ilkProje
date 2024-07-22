using ilkProje.Services.İnterfaces;

namespace ilkProje.Services
{
    public class TextLog:ILog
    {
        public void Log()
        {
            Console.WriteLine("message");
        }
    }
}
