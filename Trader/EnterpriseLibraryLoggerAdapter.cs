using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace Trader
{
    public class EnterpriseLibraryLoggerAdapter : ILoggerFacade
    {

        // TODO: Make use of the category and priority parameters
        public void Log(string message, Category category, Priority priority)
        {
            Logger.Write(message, category.ToString(), (int)priority);
        }
    }
}
