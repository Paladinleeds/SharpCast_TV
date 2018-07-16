// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var getChannelStatistics = GetChannelStatistics.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    // Ah stuff this, I'll fix it later. Need to learn more about how this particular JSON response works anyway. Snapshot of JSON response is posted at the bottom of the page.
    /*public partial class GetChannelStatistics
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("startTime")]
        public long StartTime { get; set; }

        [JsonProperty("endTime")]
        public long EndTime { get; set; }

        [JsonProperty("totalUniques")]
        public long TotalUniques { get; set; }

        [JsonProperty("totalViewtime")]
        public long TotalViewtime { get; set; }

        [JsonProperty("totalViews")]
        public long TotalViews { get; set; }

        [JsonProperty("totalCountries")]
        public long TotalCountries { get; set; }

        [JsonProperty("countries")]
        public Countries Countries { get; set; }
    }

    public partial class Countries
    {
        [JsonProperty("US")]
        public Us Us { get; set; }
    }

    public partial class Us
    {
        [JsonProperty("uniques")]
        public long Uniques { get; set; }

        [JsonProperty("views")]
        public long Views { get; set; }

        [JsonProperty("viewtime")]
        public long Viewtime { get; set; }
    }*/

    /*public partial class GetChannelStatistics
    {
        public static GetChannelStatistics FromJson(string json) => JsonConvert.DeserializeObject<GetChannelStatistics>(json, SharpCastTV.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetChannelStatistics self) => JsonConvert.SerializeObject(self, SharpCastTV.Converter.Settings);
    }*/
}

/*
 * My understanding is that the US isn't always the US and can be a different country. I think it can also be an array. Not sure how to parse this.
{
  "channel": "masta",
  "startTime": 1427673600000,
  "endTime": 1427760000000,
  "totalUniques": 1,
  "totalViewtime": 1927,
  "totalViews": 13,
  "totalCountries": 1,
  "countries": {
    "US": {
      "uniques": 1,
      "views": 13,
      "viewtime": 1927
    }
  }
}
 */
