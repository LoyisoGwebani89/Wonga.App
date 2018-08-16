﻿using System;
using Microsoft.Extensions.Logging;

namespace MessageClient.Services
{
    public class ErrorLogger<T>: IErrorLogger
    {
        #region Properties
        private readonly ILogger _logger;
        #endregion

        #region Constructors
        public ErrorLogger(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }
        #endregion

        #region Public Methods
        public void Log(LogLevel logLevel, Exception ex, string format)
        {
            _logger.Log(LogLevel.Critical, ex, format);
        }
        #endregion
    }
}