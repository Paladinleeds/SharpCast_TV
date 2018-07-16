using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class SubscriptionStatus
    {
        [JsonProperty("isSubscriber")]
        public bool IsSubscriber { get; set; }
    }
}
