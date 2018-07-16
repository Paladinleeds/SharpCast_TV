using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCast_TV.Subscription
{
    class CheckSubscriptionInfo
    {
        [JsonProperty("sub_id")]
        public string SubId { get; set; }

        [JsonProperty("sub_date_added")]
        public string SubDateAdded { get; set; }

        [JsonProperty("sub_date_valid")]
        public string SubDateValid { get; set; }

        [JsonProperty("sub_plan_id")]
        public string SubPlanId { get; set; }

        [JsonProperty("sub_payment_method")]
        public string SubPaymentMethod { get; set; }

        [JsonProperty("plan_charge")]
        public string PlanCharge { get; set; }

        [JsonProperty("plan_currency")]
        public string PlanCurrency { get; set; }

        [JsonProperty("plan_recurring")]
        public string PlanRecurring { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("cancel")]
        public object Cancel { get; set; }

        [JsonProperty("benefits")]
        public IList<object> Benefits { get; set; }

        [JsonProperty("resub")]
        public bool Resub { get; set; }
    }
}
