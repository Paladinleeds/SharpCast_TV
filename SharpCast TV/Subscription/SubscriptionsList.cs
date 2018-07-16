using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class SubscriptionsList
    {
        [JsonProperty("request")]
        public SubscriptionsListRequest Request { get; set; }

        [JsonProperty("subscriptions")]
        public IList<Subscription> Subscriptions { get; set; }
    }

    public class SubscriptionsListRequest
    {
        [JsonProperty("this")]
        public string This { get; set; }
    }

    public class Benefit
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("media")]
        public object Media { get; set; }
    }

    public class Subscription
    {
        [JsonProperty("followers")]
        public string Followers { get; set; }

        [JsonProperty("sub_id")]
        public string SubId { get; set; }

        [JsonProperty("sub_date_added")]
        public string SubDateAdded { get; set; }

        [JsonProperty("sub_date_valid")]
        public string SubDateValid { get; set; }

        [JsonProperty("sub_payment_method")]
        public string SubPaymentMethod { get; set; }

        [JsonProperty("canceled")]
        public string Canceled { get; set; }

        [JsonProperty("plan_charge")]
        public string PlanCharge { get; set; }

        [JsonProperty("plan_currency")]
        public string PlanCurrency { get; set; }

        [JsonProperty("plan_recurring")]
        public string PlanRecurring { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("user_cover")]
        public string UserCover { get; set; }

        [JsonProperty("benefits")]
        public IList<Benefit> Benefits { get; set; }
    }
}
