using log4net;

namespace MemberRegistration.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class DatabaseLogger:LoggerService
    {
        public DatabaseLogger() : base(LogManager.GetLogger("DatabaseLogger"))
        {
        }
    }
}
