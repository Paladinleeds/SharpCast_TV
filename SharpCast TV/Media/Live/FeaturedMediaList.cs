using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class FeaturedMediaList
    {
        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("media_featured_list")]
        public IList<MediaFeaturedList> MediaFeaturedList { get; set; }
    }

    public class FeaturedMediaListRequest
    {
        [JsonProperty("this")]
        public string This { get; set; }
    }

    public class MediaFeaturedList
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("media_display_name")]
        public string MediaDisplayName { get; set; }

        [JsonProperty("media_name")]
        public string MediaName { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_thumbnail_large")]
        public string MediaThumbnailLarge { get; set; }

        [JsonProperty("media_user_name")]
        public string MediaUserName { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("category_seo_key")]
        public string CategorySeoKey { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_cover")]
        public string UserCover { get; set; }

        [JsonProperty("media_backdrop_custom")]
        public object MediaBackdropCustom { get; set; }

        [JsonProperty("media_backdrop_default")]
        public string MediaBackdropDefault { get; set; }
    }
}
