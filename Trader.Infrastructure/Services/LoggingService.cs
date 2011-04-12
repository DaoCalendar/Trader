using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.Prism.Logging;

namespace Trader.Infrastructure.Services
{
    public class LoggingService : ILoggerFacade
    {
        // Simple logging adapter to the MS EnterpriseLibrary logging block.
        public void Log(string message, Category category, Priority priority)
        {
            Logger.Write(message, category.ToString(), (int)priority);
        }
    }
}
