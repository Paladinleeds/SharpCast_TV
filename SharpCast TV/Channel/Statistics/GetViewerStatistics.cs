using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace QuickType
{

    public class GetViewerStatistics
    {

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("step")]
        public int Step { get; set; }

        [JsonProperty("maxviewer")]
        public int Maxviewer { get; set; }

        [JsonProperty("maxfollower")]
        public int Maxfollower { get; set; }

        [JsonProperty("maxregistered")]
        public int Maxregistered { get; set; }

        [JsonProperty("maxembed")]
        public int Maxembed { get; set; }

        [JsonProperty("maxsubscriber")]
        public int Maxsubscriber { get; set; }

        [JsonProperty("maxandroid")]
        public int Maxandroid { get; set; }

        [JsonProperty("maxios")]
        public int Maxios { get; set; }

        [JsonProperty("maxchromecast")]
        public int Maxchromecast { get; set; }

        [JsonProperty("maxweb")]
        public int Maxweb { get; set; }

        [JsonProperty("totalads")]
        public int Totalads { get; set; }

        [JsonProperty("timeline")]
        public Timeline Timeline { get; set; }
    }
    
    public class Timeline
    {

        [JsonProperty("viewer")]
        public List<List<long>> Viewer { get; set; }

        [JsonProperty("viewer_avg")]
        public List<List<long>> ViewerAvg { get; set; }

        [JsonProperty("follower")]
        public List<List<long>> Follower { get; set; }
    }
}
