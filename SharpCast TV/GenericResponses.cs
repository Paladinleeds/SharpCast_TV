﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class SuccessResponseWithErrorCheck
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }


        public static SuccessResponseWithErrorCheck FromJson(string json) => JsonConvert.DeserializeObject<SuccessResponseWithErrorCheck>(json, SharpCastTV.Converter.Settings);
    }

    public class SuccessResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("success_msg")]
        public string SuccessMsg { get; set; }
    }

    public class ErrorResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("error_msg")]
        public string ErrorMsg { get; set; }


        public static ErrorResponse FromJson(string json) => JsonConvert.DeserializeObject<ErrorResponse>(json, SharpCastTV.Converter.Settings);
    }
}
