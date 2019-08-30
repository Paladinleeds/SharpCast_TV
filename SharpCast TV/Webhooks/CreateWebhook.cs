using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SharpCastTV
{
    public class CreateWebhookRequest
    {

        [JsonProperty("method")]
        public IList<string> method { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

    public class CreateWebhookResponse
    {

        [JsonProperty("token")]
        public string token { get; set; }

        [JsonProperty("method")]
        public IList<string> method { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }
    }

}
