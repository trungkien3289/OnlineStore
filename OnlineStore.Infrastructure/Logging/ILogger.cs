﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineStore.Infrastructure.Logging
{
    public interface ILogger
    {
        void Log(string message);
    }

}
