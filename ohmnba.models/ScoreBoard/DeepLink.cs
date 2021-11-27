using Newtonsoft.Json;
using System;

namespace ohmnba.apiModels.ScoreBoard
{
    public partial class DeepLink
    {
        [JsonProperty("broadcaster")]
        public string Broadcaster { get; set; }

        [JsonProperty("regionalMarketCodes")]
        public string RegionalMarketCodes { get; set; }

        [JsonProperty("iosApp")]
        public Uri IosApp { get; set; }

        [JsonProperty("androidApp")]
        public Uri AndroidApp { get; set; }

        [JsonProperty("desktopWeb")]
        public Uri DesktopWeb { get; set; }

        [JsonProperty("mobileWeb")]
        public Uri MobileWeb { get; set; }
    }

}
