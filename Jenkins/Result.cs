using Newtonsoft.Json;


namespace GeneXus.Server.ExternalTool.Jenkins
{
    public class Result
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("shortDesc")]
        public string ShortDesc { get; set; }
        public Result(int aCode, string aDesc, string aShortDesc)
        {
            this.Code = aCode;
            this.Desc = aDesc;
            this.ShortDesc = aShortDesc;
        }

    }
}
