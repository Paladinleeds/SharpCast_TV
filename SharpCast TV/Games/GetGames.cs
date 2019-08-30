using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace SharpCastTV
{
    public class GetGames
    {

        [JsonProperty("request")]
        public Request request { get; set; }

        [JsonProperty("category")]
        public GetGamesCategory category { get; set; }
    }

    public class GetGamesCategory
    {

        [JsonProperty("category_id")]
        public string category_id { get; set; }

        [JsonProperty("category_name")]
        public string category_name { get; set; }

        [JsonProperty("category_name_short")]
        public object category_name_short { get; set; }

        [JsonProperty("category_seo_key")]
        public string category_seo_key { get; set; }

        [JsonProperty("category_viewers")]
        public string category_viewers { get; set; }

        [JsonProperty("category_media_count")]
        public string category_media_count { get; set; }

        [JsonProperty("category_channels")]
        public object category_channels { get; set; }

        [JsonProperty("category_logo_small")]
        public object category_logo_small { get; set; }

        [JsonProperty("category_logo_large")]
        public string category_logo_large { get; set; }

        [JsonProperty("category_updated")]
        public string category_updated { get; set; }
    }

}
