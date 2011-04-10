using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace Trader.Infrastructure
{
    public class EnterpriseLibraryLoggerAdapter : ILoggerFacade
    {
        public void Log(string message, Category category, Priority priority)
        {
            Logger.Write(message, category.ToString(), (int)priority);
        }
    }
}
