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
    public class CreateVideoRequest
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("media_title")]
        public string MediaTitle { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_name")]
        public string MediaName { get; set; }

        [JsonProperty("media_hidden")]
        public string MediaHidden { get; set; }

        [JsonProperty("media_category_id")]
        public string MediaCategoryId { get; set; }

        [JsonProperty("clip_duration")]
        public int ClipDuration { get; set; }

        [JsonProperty("clip_start")]
        public int ClipStart { get; set; }

        [JsonProperty("rec_session")]
        public string RecSession { get; set; }

        [JsonProperty("original")]
        public bool Original { get; set; }
    }

    // Response from Smashcast
    public class CreateVideoResponse
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }
    }
}
