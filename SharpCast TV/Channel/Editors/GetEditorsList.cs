using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class GetEditorsList
    {
        [JsonProperty("list")]
        public IList<List> List { get; set; }
    }

    public class List
    {

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }
    }
}
