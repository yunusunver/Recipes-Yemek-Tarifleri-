using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace YemekTarifleri.Core.CrossCuttingConcerns.Logging.Log4Net
{
    public class LoggerService
    {
        private ILog _log;

        public LoggerService(ILog log)
        {
            _log = log;
        }

        public bool isInfoEnabled => _log.IsInfoEnabled;
        public bool isDebugEnabled => _log.IsDebugEnabled;
        public bool isWarnEnabled => _log.IsWarnEnabled;
        public bool isFatalEnabled => _log.IsFatalEnabled;
        public bool isErrorEnabled => _log.IsErrorEnabled;

        public void Info(object logMessage)
        {
            if (isInfoEnabled)
            {
                _log.Info(logMessage);
            }
        }

        public void Debug(object logMessage)
        {
            if (isDebugEnabled)
            {
                _log.Debug(logMessage);
            }
        }

        public void Warn(object logMessage)
        {
            if (isWarnEnabled)
            {
                _log.Warn(logMessage);
            }
        }

        public void Fatal(object logMessage)
        {
            if (isFatalEnabled)
            {
                _log.Fatal(logMessage);
            }
        }

        public void Error(object logMessage)
        {
            if (isErrorEnabled)
            {
                _log.Error(logMessage);
            }
        }


    }
}
