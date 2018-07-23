using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class CreateTeam
    {
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("group_user_name")]
        public string GroupUserName { get; set; }

        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("group_text")]
        public string GroupText { get; set; }

        [JsonProperty("group_display_name")]
        public string GroupDisplayName { get; set; }
    }
}
