﻿using OnlineStore.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineStore.Infrastructure.Logging
{
    public class LoggingFactory
    {
        private static ILogger _logger;

        public static void InitializeLogFactory(ILogger logger)
        {
            _logger = logger;
        }

        public static ILogger GetLogger()
        {
            return _logger;
        }
    }
}
