using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// INFO: The PUT payload and the response both use the same JSON.

namespace SharpCastTV
{
    class UpdateTeam
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("invites")]
        public IList<string> Invites { get; set; }
    }

    public class UpdateTeamInfo
    {
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("founder_name")]
        public string FounderName { get; set; }

        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("group_display_name")]
        public string GroupDisplayName { get; set; }

        [JsonProperty("group_text")]
        public string GroupText { get; set; }

        [JsonProperty("group_logo_small")]
        public string GroupLogoSmall { get; set; }

        [JsonProperty("group_logo_large")]
        public string GroupLogoLarge { get; set; }

        [JsonProperty("group_cover")]
        public string GroupCover { get; set; }
    }
}
