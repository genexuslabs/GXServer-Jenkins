using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneXus.Server.ExternalTool.Jenkins
{
    class Results
    {
        [JsonProperty("result")]
        public List<Result> Result { get; set; }
        public Results(List<Result> aResults)
        {
            this.Result = aResults;
        }
    }
}

