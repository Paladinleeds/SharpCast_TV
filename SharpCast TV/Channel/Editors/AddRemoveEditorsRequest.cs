using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace QuickType
{
    class AddRemoveEditorsRequest
    {
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("editor")]
        public string Editor { get; set; }

        [JsonProperty("remove")]
        public bool Remove { get; set; }
    }
}
