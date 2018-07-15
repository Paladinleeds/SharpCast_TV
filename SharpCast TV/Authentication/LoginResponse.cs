// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var loginResponse = LoginResponse.FromJson(jsonString);

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LoginResponse
    {
        [JsonProperty("user_id")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("user_banned")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long UserBanned { get; set; }

        [JsonProperty("user_partner")]
        public object UserPartner { get; set; }

        [JsonProperty("user_banned_channel")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long UserBannedChannel { get; set; }

        [JsonProperty("superadmin")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long Superadmin { get; set; }

        [JsonProperty("livestream_count")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long LivestreamCount { get; set; }

        [JsonProperty("followers")]
        [JsonConverter(typeof(ParseIntegerConverter))]
        public long Followers { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public LoginResponse Data { get; set; }

        [JsonProperty("access", NullValueHandling = NullValueHandling.Ignore)]
        public string Access { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }
    }

    /*public partial class LoginResponse
    {
        public static LoginResponse FromJson(string json) => JsonConvert.DeserializeObject<LoginResponse>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LoginResponse self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }*/
    
    internal class ParseIntegerConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseIntegerConverter Singleton = new ParseIntegerConverter();
    }
}
