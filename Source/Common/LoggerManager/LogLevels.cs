﻿using System.Collections.Generic;

namespace Common.LoggerManager
{
    public enum LogLevel
    {
        Trace = 0,
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4,
        Critical = 5,
    }

    public enum LOGLEVELS
    {
        NONE = 0x00,
        DEBUG = 0x01,
        INFO = 0x02,
        WARNING = 0x04,
        ERROR = 0x08,
        FATAL = 0x10
    }
    
    public static class LogLevels
    {
        public static Dictionary<LOGLEVELS, string> LogLevelsDictonary = new Dictionary<LOGLEVELS, string>()
        {
            { LOGLEVELS.NONE   , "NONE"    },
            { LOGLEVELS.DEBUG  , "DEBUG"   },
            { LOGLEVELS.INFO   , "INFO"    },
            { LOGLEVELS.WARNING, "WARNING" },
            { LOGLEVELS.ERROR  , "ERROR"   },
            { LOGLEVELS.FATAL  , "FATAL"   }
        };
    }
}
