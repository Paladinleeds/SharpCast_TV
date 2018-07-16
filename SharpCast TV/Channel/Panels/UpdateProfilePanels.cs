using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class UpdateProfilePanels
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("profile")]
        public Profile Profile { get; set; }
    }

    public class UpdatePanel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class UpdateSorted
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("$index")]
        public int Index { get; set; }
    }

    public class UpdateProfile
    {
        [JsonProperty("panels")]
        public IList<Panel> Panels { get; set; }

        [JsonProperty("sorted")]
        public IList<Sorted> Sorted { get; set; }

        [JsonProperty("preview")]
        public IList<object> Preview { get; set; }
    }
}
