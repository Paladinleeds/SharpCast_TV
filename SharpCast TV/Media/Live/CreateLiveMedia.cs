using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// Not sure if this will work - if anyone who sees the code can let me know, that'd be great!

namespace QuickType
{
    // Request to Smashcast
    public class CreateLiveMediaRequest
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("media_description")]
        public string MediaDescription { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_name")]
        public string MediaName { get; set; }

        [JsonProperty("media_category_id")]
        public string MediaCategoryId { get; set; }
    }

    // Response from Smashcast
    public class CreateLiveMediaResponse
    {
        [JsonProperty("media_id")]
        public int MediaId { get; set; }
    }
}
