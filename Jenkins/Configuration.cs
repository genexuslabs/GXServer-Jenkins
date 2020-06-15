using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeneXus.Server.ExternalTool.Jenkins
{
    public class Configuration
    {
        [JsonProperty("instance")]
        public List<JenkinsServer> JenkinsInstance { get; set; }

    }
}
