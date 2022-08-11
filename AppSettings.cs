using System.Collections.Generic;

namespace PCAgile.Core.Configuration
{
    public class AppSettings
    {
        public string AppEnvironment { get; set; }
        public string AppVersion { get; set; }

        public ShadlineSection Shadline { get; set; }

        public class ShadlineSection
        {
            public string BaseUrl { get; set; }
            public string ApiKey { get; set; }
            public Dictionary<string, ContainerSection> Containers { get; set; }
        }

        public class ContainerSection
        {
            public string UserKey { get; set; }
            public Dictionary<string, FolderSection> Folders { get; set; }
        }

        public class FolderSection
        {
            public string FolderUuid { get; set; }
            public string FolderPath { get; set; }
            public int ExpirationSeconds { get; set; }
            public string CRON { get; set; }
        }
    }
}
