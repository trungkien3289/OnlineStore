using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineStore.Infrastructure.Configuration
{
    public interface IApplicationSettings
    {
        string LoggerName { get; }
    }
}
