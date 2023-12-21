using System;

namespace MIFARE_APP.Config
{
    [Serializable]
    internal class AppConfig
    {
        public Application Application { get; set; }
        public LoggerManager LoggerManager { get; set; }
    }
}
