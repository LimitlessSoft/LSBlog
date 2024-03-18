using LSCore.Framework.Extensions;

namespace LSB.Api
{
    public class Program
    {
        public static void Main(string[] args) =>
            LSCoreStartupExtensions.InitializeLSCoreApplication<Startup>(args);
    }
}