// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var getStreamedSecondsStatistics = GetStreamedSecondsStatistics.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetStreamedSecondsStatistics
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("startTime")]
        public long StartTime { get; set; }

        [JsonProperty("endTime")]
        public long EndTime { get; set; }

        [JsonProperty("streamed_seconds")]
        public long StreamedSeconds { get; set; }
    }

    /*public partial class GetStreamedSecondsStatistics
    {
        public static GetStreamedSecondsStatistics FromJson(string json) => JsonConvert.DeserializeObject<GetStreamedSecondsStatistics>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetStreamedSecondsStatistics self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
}
