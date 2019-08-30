using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SharpCastTV
{
    public class Setting
    {

        [JsonProperty("guild_id")]
        public string guild_id { get; set; }

        [JsonProperty("join_type")]
        public string join_type { get; set; }

        [JsonProperty("sub_role")]
        public string sub_role { get; set; }

        [JsonProperty("mod_role")]
        public object mod_role { get; set; }

        [JsonProperty("sub_lapse")]
        public int sub_lapse { get; set; }

        [JsonProperty("kick_lapse")]
        public bool kick_lapse { get; set; }

        [JsonProperty("emotes")]
        public bool emotes { get; set; }

        [JsonProperty("notification_channel")]
        public object notification_channel { get; set; }

        [JsonProperty("live_notify")]
        public bool live_notify { get; set; }
    }

    public class ListDiscordGuilds
    {

        [JsonProperty("settings")]
        public IList<Setting> settings { get; set; }
    }
}
