using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeneXus.Server.ExternalTool.Jenkins
{
    public class JenkinsServer
    {
       [JsonProperty("host")]
        public string Host { get; set;}

        [JsonProperty("projectName")]
        public List<string>  ProjectName{get; set;}

        [JsonProperty("userName")]
        public string UserName {get; set;}

        [JsonProperty("userToken")]
        public string UserToken {get; set;}

    }
}
