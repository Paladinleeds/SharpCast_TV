using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace QuickType
{
    // Working on fixing this. Broken API calls are currently commented out.
    public class RevenuesRequestInfo
    {
        [JsonProperty("this")]
        public string This { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class RevenuesSummary
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("total_earnings")]
        public double TotalEarnings { get; set; }

        [JsonProperty("max_earnings")]
        public double MaxEarnings { get; set; }

        [JsonProperty("viewed_hours")]
        public double ViewedHours { get; set; }

        [JsonProperty("unique_user")]
        public int UniqueUser { get; set; }
    }

    public class RevenuesPlan
    {
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        [JsonProperty("plan_group_id")]
        public object PlanGroupId { get; set; }

        [JsonProperty("plan_user_id")]
        public string PlanUserId { get; set; }

        [JsonProperty("plan_countries")]
        public string PlanCountries { get; set; }

        [JsonProperty("plan_cpm")]
        public string PlanCpm { get; set; }

        [JsonProperty("plan_currency")]
        public string PlanCurrency { get; set; }

        [JsonProperty("plan_date_added")]
        public string PlanDateAdded { get; set; }
    }

    public class EarningsInfo
    {
        [JsonProperty("earnings")]
        public double Earnings { get; set; }
    }

    public class RevenuesStatistics
    {
        [JsonProperty("summary")]
        public RevenuesSummary Summary { get; set; }

        [JsonProperty("plans")]
        public IList<RevenuesPlan> Plans { get; set; }

        [JsonProperty("timeline")]
        public IList<IList<long>> Timeline { get; set; }

        [JsonProperty("daily")]
        public Dictionary<string, EarningsInfo> Daily { get; set; }

        [JsonProperty("groups")]
        public Dictionary<string, List<object>> Groups { get; set; }

        [JsonProperty("live")]
        public Dictionary<string, double> Live { get; set; }

        [JsonProperty("total")]
        public Dictionary<string, double> Total { get; set; }

        [JsonProperty("subs")]
        public Dictionary<string, double> Subs { get; set; }

        [JsonProperty("timeline_ads")]
        public IList<IList<long>> TimelineAds { get; set; }

        [JsonProperty("timeline_subs")]
        public IList<IList<long>> TimelineSubs { get; set; }

        [JsonProperty("top")]
        public RevenuesTopInfo Top { get; set; }
    }

    public class RevenuesTopContentInfo
    {
        [JsonProperty("live")]
        public EarningsInfo Live { get; set; }

        [JsonProperty("video")]
        public EarningsInfo Video { get; set; }

        [JsonProperty("subscriptions")]
        public EarningsInfo Subscriptions { get; set; }
    }

    public class RevenuesTopInfo
    {
        [JsonProperty("countries")]
        public Dictionary<string, double> Countries { get; set; }

        [JsonProperty("content")]
        public RevenuesTopContentInfo Content { get; set; }
    }

    public class GetRevenueStatistics
    {

        [JsonProperty("request")]
        public RevenuesRequestInfo Request { get; set; }

        [JsonProperty("revenues")]
        public RevenuesStatistics Revenues { get; set; }
        
        /*public static GetChannelStatistics FromJson(string json)
        {
            return JsonConvert.DeserializeObject<GetChannelStatistics>(json, QuickType.Converter.Settings);
        }
        
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, QuickType.Converter.Settings);
        }*/
    }
}
/*
 {
  "request": {
    "this": "/revenues/channel/masta",
    "type": "channel",
    "user": "masta"
  },
  "revenues": {
    "summary": {
      "currency": "USD",
      "last_updated": "2016-01-01 00:00:00",
      "total_earnings": 0,
      "max_earnings": 0,
      "viewed_hours": 0,
      "unique_user": 0
    },
    "plans": [
      {
        "plan_id": "1",
        "plan_name": "masta",
        "plan_group_id": null,
        "plan_user_id": "1",
        "plan_countries": "*",
        "plan_cpm": "0.00",
        "plan_currency": "USD",
        "plan_date_added": "2015-08-03 00:00:00"
      },
      {
        "plan_id": "2",
        "plan_name": "masta",
        "plan_group_id": null,
        "plan_user_id": "1",
        "plan_countries": "Austria,Germany,Switzerland",
        "plan_cpm": "0.00",
        "plan_currency": "USD",
        "plan_date_added": "2015-08-03 00:00:00"
      },
      {
        "plan_id": "3",
        "plan_name": "masta",
        "plan_group_id": null,
        "plan_user_id": "1",
        "plan_countries": "Australia,Belgium,Canada,Denmark,Finland,France,Luxembourg,Netherlands,Norway,Sweden,United Kingdom,United States",
        "plan_cpm": "0.00",
        "plan_currency": "USD",
        "plan_date_added": "2015-08-03 00:00:00"
      },
      {
        "plan_id": "4",
        "plan_name": "masta",
        "plan_group_id": null,
        "plan_user_id": "1",
        "plan_countries": "Australia,Belgium,Canada,Denmark,Finland,France,Luxembourg,Netherlands,Norway,Sweden,United Kingdom,United States",
        "plan_cpm": "0.00",
        "plan_currency": "USD",
        "plan_date_added": "2015-04-26 00:00:00"
      },
      {
        "plan_id": "5",
        "plan_name": "masta",
        "plan_group_id": null,
        "plan_user_id": "1",
        "plan_countries": "*",
        "plan_cpm": "0.00",
        "plan_currency": "USD",
        "plan_date_added": "2015-04-26 00:00:00"
      },
      {
        "plan_id": "6",
        "plan_name": "masta",
        "plan_group_id": null,
        "plan_user_id": "1",
        "plan_countries": "Austria,Germany,Switzerland",
        "plan_cpm": "0.00",
        "plan_currency": "USD",
        "plan_date_added": "2015-04-26 00:00:00"
      }
    ],
    "timeline": [
      [
        1448928000000,
        0
      ]
    ],
    "daily": {
      "2015-12-01": {
        "earnings": 0
      }
    },
    "groups": {
      "1448928000000": [
        null,
        null
      ]
    },
    "live": {
      "1448928000000": 0
    },
    "total": {
      "1448928000000": 0
    },
    "timeline_ads": [
      [
        1448928000000,
        0
      ]
    ],
    "timeline_subs": [
      [
        1448928000000,
        0
      ]
    ],
    "subs": {
      "1448928000000": 0
    },
    "top": {
      "countries": {
        "United States": 0
      },
      "content": {
        "live": {
          "earnings": 0
        },
        "video": {
          "earnings": 0
        },
        "subscriptions": {
          "earnings": 0
        }
      }
    }
  }
}
*/
