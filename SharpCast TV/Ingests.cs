using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SharpCast_TV
{
    public class Ingests
    {

        [JsonProperty("ingest_location")]
        public string ingest_location { get; set; }

        [JsonProperty("ingest_url")]
        public string ingest_url { get; set; }
    }
}
