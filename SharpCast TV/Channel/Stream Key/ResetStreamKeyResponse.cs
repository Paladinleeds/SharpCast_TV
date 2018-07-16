// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using SharpCastTV;
//
//    var reserStreamKeyResponse = ReserStreamKeyResponse.FromJson(jsonString);

namespace SharpCastTV
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ResetStreamKeyResponse
    {
        [JsonProperty("streamKey")]
        public string StreamKey { get; set; }
    }

    public partial class ResetStreamKeyResponse
    {
        public static ResetStreamKeyResponse FromJson(string json) => JsonConvert.DeserializeObject<ResetStreamKeyResponse>(json, SharpCastTV.Converter.Settings);
    }

    
}
