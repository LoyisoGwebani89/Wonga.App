using System;
using Microsoft.Extensions.Logging;

namespace MessageClient.Services
{
    public interface IErrorLogger
    {
        void Log(LogLevel logLevel, Exception ex, string format);
    }
}