using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// WARNING: To correctly update this API, You must send all values except media_description or media_hosted_name, which is optional unless you want to update the channel description or set host mode.
// If the channel does not yet have a streaming channel you will need to use CreateLiveMedia instead

namespace SharpCastTV
{
    // Request to Smashcast
    public class UpdateLiveMediaRequest
    {
        [JsonProperty("livestream")]
        public IList<MediaRequestLivestream> Livestream { get; set; }
    }

    public class MediaRequestLivestream
    {
        [JsonProperty("media_user_name")]
        public string MediaUserName { get; set; }

        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("media_category_id")]
        public string MediaCategoryId { get; set; }

        [JsonProperty("media_live_delay")]
        public string MediaLiveDelay { get; set; }

        [JsonProperty("media_recording")]
        public string MediaRecording { get; set; }

        [JsonProperty("media_mature")]
        public string MediaMature { get; set; }

        [JsonProperty("media_hosted_name")]
        public string MediaHostedName { get; set; }

        [JsonProperty("media_countries")]
        public IList<string> MediaCountries { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_description")]
        public string MediaDescription { get; set; }
    }

    public class UpdateLiveMediaResponse
    {
        [JsonProperty("livestream")]
        public IList<MediaResponseLivestream> Livestream { get; set; }
    }

    // Response from Smashcast
    public class MediaResponseLivestream
    {
        [JsonProperty("media_user_name")]
        public string MediaUserName { get; set; }

        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("media_category_id")]
        public string MediaCategoryId { get; set; }

        [JsonProperty("media_live_delay")]
        public string MediaLiveDelay { get; set; }

        [JsonProperty("media_recording")]
        public string MediaRecording { get; set; }

        [JsonProperty("media_mature")]
        public string MediaMature { get; set; }

        [JsonProperty("media_countries")]
        public IList<string> MediaCountries { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_description_md")]
        public object MediaDescriptionMd { get; set; }
    }
}
