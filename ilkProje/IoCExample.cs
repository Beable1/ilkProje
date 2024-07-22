using ilkProje.Services;

namespace ilkProje
{
    public class IoCExample
    {
        public IoCExample()
        {
            IServiceCollection services = new ServiceCollection();
            services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog(5)));
            services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));

            ServiceProvider provider= services.BuildServiceProvider();

            //provider.GetService<ConsoleLog>();
            //provider.GetService<TextLog>();
        }
    }
}
