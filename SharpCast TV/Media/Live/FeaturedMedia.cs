using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class FeaturedMedia
    {
        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("media_display_name")]
        public string MediaDisplayName { get; set; }

        [JsonProperty("media_name")]
        public string MediaName { get; set; }

        [JsonProperty("backdrop")]
        public string Backdrop { get; set; }

        [JsonProperty("backdrop_html")]
        public string BackdropHtml { get; set; }
    }
}
