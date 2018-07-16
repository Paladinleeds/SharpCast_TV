using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class GetRecordings
    {
        [JsonProperty("rec_id")]
        public string RecId { get; set; }

        [JsonProperty("rec_media_id")]
        public string RecMediaId { get; set; }

        [JsonProperty("rec_session")]
        public string RecSession { get; set; }

        [JsonProperty("rec_title")]
        public string RecTitle { get; set; }

        [JsonProperty("rec_category_id")]
        public string RecCategoryId { get; set; }

        [JsonProperty("rec_path")]
        public string RecPath { get; set; }

        [JsonProperty("rec_name")]
        public string RecName { get; set; }

        [JsonProperty("rec_addr")]
        public string RecAddr { get; set; }

        [JsonProperty("rec_info")]
        public RecInfo RecInfo { get; set; }

        [JsonProperty("rec_height")]
        public string RecHeight { get; set; }

        [JsonProperty("rec_bitrate")]
        public string RecBitrate { get; set; }

        [JsonProperty("rec_duration")]
        public string RecDuration { get; set; }

        [JsonProperty("rec_date_added")]
        public string RecDateAdded { get; set; }

        [JsonProperty("rec_saved_media_id")]
        public object RecSavedMediaId { get; set; }

        [JsonProperty("rec_done")]
        public object RecDone { get; set; }

        [JsonProperty("rec_uploaded")]
        public string RecUploaded { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("thumbnail_large")]
        public string ThumbnailLarge { get; set; }

        [JsonProperty("rec_duration_sec")]
        public string RecDurationSec { get; set; }

        [JsonProperty("rec_download_link")]
        public string RecDownloadLink { get; set; }
    }

    public class Disposition
    {
        [JsonProperty("default")]
        public int Default { get; set; }

        [JsonProperty("dub")]
        public int Dub { get; set; }

        [JsonProperty("original")]
        public int Original { get; set; }

        [JsonProperty("comment")]
        public int Comment { get; set; }

        [JsonProperty("lyrics")]
        public int Lyrics { get; set; }

        [JsonProperty("karaoke")]
        public int Karaoke { get; set; }

        [JsonProperty("forced")]
        public int Forced { get; set; }

        [JsonProperty("hearing_impaired")]
        public int HearingImpaired { get; set; }

        [JsonProperty("visual_impaired")]
        public int VisualImpaired { get; set; }

        [JsonProperty("clean_effects")]
        public int CleanEffects { get; set; }

        [JsonProperty("attached_pic")]
        public int AttachedPic { get; set; }
    }

    public class RecInfo
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("codec_name")]
        public string CodecName { get; set; }

        [JsonProperty("codec_long_name")]
        public string CodecLongName { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("codec_type")]
        public string CodecType { get; set; }

        [JsonProperty("codec_time_base")]
        public string CodecTimeBase { get; set; }

        [JsonProperty("codec_tag_string")]
        public string CodecTagString { get; set; }

        [JsonProperty("codec_tag")]
        public string CodecTag { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("has_b_frames")]
        public int HasBFrames { get; set; }

        [JsonProperty("sample_aspect_ratio")]
        public string SampleAspectRatio { get; set; }

        [JsonProperty("display_aspect_ratio")]
        public string DisplayAspectRatio { get; set; }

        [JsonProperty("pix_fmt")]
        public string PixFmt { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("r_frame_rate")]
        public string RFrameRate { get; set; }

        [JsonProperty("avg_frame_rate")]
        public string AvgFrameRate { get; set; }

        [JsonProperty("time_base")]
        public string TimeBase { get; set; }

        [JsonProperty("start_pts")]
        public int StartPts { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("disposition")]
        public Disposition Disposition { get; set; }
    }
}
