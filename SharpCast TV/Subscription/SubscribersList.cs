using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class SubscribersList
    {
        [JsonProperty("request")]
        public SubscriberListRequest Request { get; set; }

        [JsonProperty("subscribers")]
        public IList<Subscriber> Subscribers { get; set; }
    }

    public class SubscriberListRequest
    {
        [JsonProperty("this")]
        public string This { get; set; }
    }

    public class Subscriber
    {
        [JsonProperty("followers")]
        public string Followers { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("sub_date_added")]
        public string SubDateAdded { get; set; }

        [JsonProperty("sub_date_valid")]
        public string SubDateValid { get; set; }

        [JsonProperty("sub_payment_method")]
        public string SubPaymentMethod { get; set; }

        [JsonProperty("canceled")]
        public object Canceled { get; set; }
    }
}
