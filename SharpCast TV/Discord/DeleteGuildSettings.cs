using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SharpCastTV
{
    public class DeleteGuildSettings
    {

        [JsonProperty("success")]
        public bool success { get; set; }

        [JsonProperty("error")]
        public bool error { get; set; }

        [JsonProperty("msg")]
        public string msg { get; set; }
    }
}
