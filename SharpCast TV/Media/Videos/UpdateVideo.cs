using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    // Request to Smashcast
    public class UpdateVideoRequest
    {
        [JsonProperty("video")]
        public IList<RequestVideo> Video { get; set; }
    }

    public class RequestVideo
    {
        [JsonProperty("media_user_name")]
        public string MediaUserName { get; set; }

        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("media_category_id")]
        public string MediaCategoryId { get; set; }

        [JsonProperty("media_hidden")]
        public string MediaHidden { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_description")]
        public string MediaDescription { get; set; }
    }

    // Response from Smashcast
    public class UpdateVideoResponse
    {
        [JsonProperty("video")]
        public IList<ResponseVideo> Video { get; set; }

        [JsonProperty("livestream")]
        public IList<Livestream> Livestream { get; set; }
    }

    public class ResponseVideo
    {
        [JsonProperty("media_user_name")]
        public string MediaUserName { get; set; }

        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("media_category_id")]
        public string MediaCategoryId { get; set; }

        [JsonProperty("media_hidden")]
        public string MediaHidden { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_description")]
        public string MediaDescription { get; set; }
    }

    public class UpdateVideoLivestream
    {
        [JsonProperty("media_description_md")]
        public object MediaDescriptionMd { get; set; }
    }
}
