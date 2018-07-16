using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{ 
    class UserRelated
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("livestream")]
        public IList<Livestream> Livestream { get; set; }
    }

    public class RelatedChannel
    {
        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("channel_link")]
        public string ChannelLink { get; set; }
    }

    public class RelatedLivestream
    {
        [JsonProperty("media_display_name")]
        public string MediaDisplayName { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_name")]
        public string MediaName { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("category_seo_key")]
        public string CategorySeoKey { get; set; }

        [JsonProperty("media_views")]
        public string MediaViews { get; set; }

        [JsonProperty("media_countries")]
        public IList<string> MediaCountries { get; set; }

        [JsonProperty("media_live_since")]
        public string MediaLiveSince { get; set; }

        [JsonProperty("media_is_live")]
        public string MediaIsLive { get; set; }

        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("media_thumbnail")]
        public string MediaThumbnail { get; set; }

        [JsonProperty("media_thumbnail_large")]
        public string MediaThumbnailLarge { get; set; }

        [JsonProperty("channel")]
        public RelatedChannel Channel { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("recommended")]
        public bool Recommended { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }
    }

}
