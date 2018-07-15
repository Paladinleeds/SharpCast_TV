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
    public partial class Request
    {

        //[JsonProperty("this")]
        //public string This { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class Summary
    {

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("total_earnings")]
        public int TotalEarnings { get; set; }

        [JsonProperty("max_earnings")]
        public int MaxEarnings { get; set; }

        [JsonProperty("viewed_hours")]
        public int ViewedHours { get; set; }

        [JsonProperty("unique_user")]
        public int UniqueUser { get; set; }
    }

    public class Plan
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

    /* ... is this even needed? Detecting a PEBCAK here
    public class DailyEarnings
    {
        [JsonProperty("earnings")]
        public int Earnings { get; set; }
    }*/

    public class DailyStatistics
    {
        [JsonProperty("earnings")]
        public int Earnings { get; set; }
    }

    public class RevenuesStatistics
    {
        [JsonProperty("daily")]
        public Dictionary<string, DailyStatistics> Daily { get; set; }

        [JsonProperty("groups")]
        public Dictionary<string, object> Groups { get; set; }

        [JsonProperty("live")]
        public Dictionary<string, int> Live { get; set; }

        [JsonProperty("total")]
        public Dictionary<string, int> Total { get; set; }

        [JsonProperty("subs")]
        //public int 1448928000000 { get; set; }
        public Dictionary<string, int> Subs { get; set; }
    }

    public class Countries
    {

        [JsonProperty("United States")]
        public int UnitedStates { get; set; }
    }

    public class Video
    {

        [JsonProperty("earnings")]
        public int Earnings { get; set; }
    }

    public class Subscriptions
    {

        [JsonProperty("earnings")]
        public int Earnings { get; set; }
    }

    /*public class Content
    {

        [JsonProperty("live")]
        public Live { get; set; }

        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("subscriptions")]
        public Subscriptions Subscriptions { get; set; }
    }

    public class Top
    {

        [JsonProperty("countries")]
        public Countries Countries { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }
    }

    public class Revenues
    {

        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("plans")]
        public IList<Plan> Plans { get; set; }

        [JsonProperty("timeline")]
        public IList<IList<long>> Timeline { get; set; }

        [JsonProperty("daily")]
        public Daily Daily { get; set; }

        [JsonProperty("groups")]
        public Groups Groups { get; set; }

        [JsonProperty("live")]
        public Live Live { get; set; }

        [JsonProperty("total")]
        public Total Total { get; set; }

        [JsonProperty("timeline_ads")]
        public IList<IList<long>> TimelineAds { get; set; }

        [JsonProperty("timeline_subs")]
        public IList<IList<long>> TimelineSubs { get; set; }

        [JsonProperty("subs")]
        public Subs Subs { get; set; }

        [JsonProperty("top")]
        public Top Top { get; set; }
    }

    public class GetRevenueStatistics
    {

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("revenues")]
        public Revenues Revenues { get; set; }
    }*/
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