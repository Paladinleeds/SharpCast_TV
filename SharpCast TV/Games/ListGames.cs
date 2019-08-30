using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{

    public class ListGames
    {
        [JsonProperty("request")]
        public ListGamesRequest Request { get; set; }

        [JsonProperty("categories")]
        public ListGamesCategory[] Categories { get; set; }
    }

    public class ListGamesRequest
    {
        [JsonProperty("this")]
        public string This { get; set; }
    }

    public class ListGamesCategory
    {
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("category_name_short")]
        public object CategoryNameShort { get; set; }

        [JsonProperty("category_seo_key")]
        public string CategorySeoKey { get; set; }

        [JsonProperty("category_viewers")]
        public string CategoryViewers { get; set; }

        [JsonProperty("category_logo_small")]
        public object CategoryLogoSmall { get; set; }

        [JsonProperty("category_logo_large")]
        public string CategoryLogoLarge { get; set; }
    }
}
