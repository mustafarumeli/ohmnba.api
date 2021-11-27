using Newtonsoft.Json;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class Internal
    {
        [JsonProperty("pubDateTime")]
        public string PubDateTime { get; set; }

        [JsonProperty("igorPath")]
        public string IgorPath { get; set; }

        [JsonProperty("routeName")]
        public string RouteName { get; set; }

        [JsonProperty("routeValue")]
        public string RouteValue { get; set; }

        [JsonProperty("xslt")]
        public string Xslt { get; set; }

        [JsonProperty("xsltForceRecompile")]
        public bool XsltForceRecompile { get; set; }

        [JsonProperty("xsltInCache")]
        public bool XsltInCache { get; set; }

        [JsonProperty("xsltCompileTimeMillis")]
        public string XsltCompileTimeMillis { get; set; }

        [JsonProperty("xsltTransformTimeMillis")]
        public string XsltTransformTimeMillis { get; set; }

        [JsonProperty("consolidatedDomKey")]
        public string ConsolidatedDomKey { get; set; }

        [JsonProperty("endToEndTimeMillis")]
        public string EndToEndTimeMillis { get; set; }
    }

}
