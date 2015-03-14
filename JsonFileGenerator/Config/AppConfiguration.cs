using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonFileGenerator.Config
{
    public class AppConfiguration: ConfigurationSection
    {
        [ConfigurationProperty("outputPath", IsRequired = true)]
        public string OutputPath
        {
            get { return (string)this["outputPath"]; }
            set { this["outputPath"] = value; }
        }

        public static AppConfiguration Config
        {
            get { return ConfigurationManager.GetSection("appConfiguration") as AppConfiguration; }
        }
    }
}
