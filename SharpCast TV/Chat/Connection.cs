using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SharpCastTV
{
    public class Connection
    {

        [JsonProperty("server_ip")]
        public string server_ip { get; set; }
    }
}
