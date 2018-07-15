// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var getStreamKeyResponse = GetStreamKeyResponse.FromJson(jsonString);

namespace QuickType.Channel.Stream_Key
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GetStreamKeyResponse
    {
        [JsonProperty("streamKey")]
        public string StreamKey { get; set; }
    }

    public partial class GetStreamKeyResponse
    {
        public static GetStreamKeyResponse FromJson(string json) => JsonConvert.DeserializeObject<GetStreamKeyResponse>(json, QuickType.Channel.Stream_Key.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GetStreamKeyResponse self) => JsonConvert.SerializeObject(self, QuickType.Channel.Stream_Key.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

