using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class GetGameAccounts
    {
        [JsonProperty("gameaccounts")]
        public IList<Gameaccount> Gameaccounts { get; set; }
    }

    public class Gameaccount
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("lol_region")]
        public string LolRegion { get; set; }

        [JsonProperty("lol_account")]
        public string LolAccount { get; set; }

        [JsonProperty("lol_stats")]
        public string LolStats { get; set; }

        [JsonProperty("lol_stats_updated")]
        public string LolStatsUpdated { get; set; }

        [JsonProperty("wot_account")]
        public string WotAccount { get; set; }

        [JsonProperty("wot_stats")]
        public string WotStats { get; set; }

        [JsonProperty("wot_stats_updated")]
        public string WotStatsUpdated { get; set; }
    }
}
