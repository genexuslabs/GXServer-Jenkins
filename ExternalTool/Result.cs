using Newtonsoft.Json;

namespace GeneXus.Server.ExternalTool
{
    public class Result
    {
        private int _code;
        private string _description;
        private string _shortDescription;

        public Result(int pCode, string pDescription, string pShortDescription)
        {
            this._code = pCode;
            this._description = pDescription;
            this._shortDescription = pShortDescription;
        }

        public Result()
        {

        }


        [JsonProperty("code")]
        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        [JsonProperty("desc")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [JsonProperty("shortDesc")]
        public string ShortDescription
        {
            get { return _shortDescription; }
            set { _shortDescription = value; }
        }
    }
}