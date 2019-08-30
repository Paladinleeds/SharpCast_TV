using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SharpCastTV
{
    public class Category
    {

        [JsonProperty("category_id")]
        public string category_id { get; set; }

        [JsonProperty("category_name")]
        public string category_name { get; set; }
    }

    public class SearchGames
    {

        [JsonProperty("request")]
        public Request request { get; set; }

        [JsonProperty("categories")]
        public IList<Category> categories { get; set; }
    }
}
