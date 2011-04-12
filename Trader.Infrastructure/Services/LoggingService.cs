using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.Prism.Logging;

namespace Trader.Infrastructure.Services
{
    public class LoggingService : ILoggerFacade
    {
        public void Log(string message, Category category, Priority priority)
        {
            Logger.Write(message, category.ToString(), (int)priority);
        }
    }
}
