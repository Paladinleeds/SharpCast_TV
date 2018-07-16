using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class GetVideos
    {
        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("video")]
        public IList<Video> Video { get; set; }
    }

    public class GetVideosRequest
    {
        [JsonProperty("this")]
        public string This { get; set; }
    }

    public class GetVideosChannel
    {
        [JsonProperty("followers")]
        public string Followers { get; set; }

        [JsonProperty("videos")]
        public string Videos { get; set; }

        [JsonProperty("recordings")]
        public string Recordings { get; set; }

        [JsonProperty("teams")]
        public string Teams { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_status")]
        public string UserStatus { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_cover")]
        public string UserCover { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("user_partner")]
        public string UserPartner { get; set; }

        [JsonProperty("partner_type")]
        public object PartnerType { get; set; }

        [JsonProperty("user_beta_profile")]
        public string UserBetaProfile { get; set; }

        [JsonProperty("media_is_live")]
        public string MediaIsLive { get; set; }

        [JsonProperty("media_live_since")]
        public string MediaLiveSince { get; set; }

        [JsonProperty("user_media_id")]
        public string UserMediaId { get; set; }

        [JsonProperty("twitter_account")]
        public string TwitterAccount { get; set; }

        [JsonProperty("twitter_enabled")]
        public string TwitterEnabled { get; set; }

        [JsonProperty("livestream_count")]
        public string LivestreamCount { get; set; }
    }

    public class Video
    {
        [JsonProperty("media_user_name")]
        public string MediaUserName { get; set; }

        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("media_file")]
        public string MediaFile { get; set; }

        [JsonProperty("media_user_id")]
        public string MediaUserId { get; set; }

        [JsonProperty("media_profiles")]
        public string MediaProfiles { get; set; }

        [JsonProperty("media_type_id")]
        public string MediaTypeId { get; set; }

        [JsonProperty("media_is_live")]
        public string MediaIsLive { get; set; }

        [JsonProperty("media_live_delay")]
        public string MediaLiveDelay { get; set; }

        [JsonProperty("media_date_added")]
        public string MediaDateAdded { get; set; }

        [JsonProperty("media_live_since")]
        public object MediaLiveSince { get; set; }

        [JsonProperty("media_transcoding")]
        public object MediaTranscoding { get; set; }

        [JsonProperty("media_chat_enabled")]
        public string MediaChatEnabled { get; set; }

        [JsonProperty("media_countries")]
        public object MediaCountries { get; set; }

        [JsonProperty("media_hosted_id")]
        public object MediaHostedId { get; set; }

        [JsonProperty("media_mature")]
        public object MediaMature { get; set; }

        [JsonProperty("media_hidden")]
        public object MediaHidden { get; set; }

        [JsonProperty("user_banned")]
        public object UserBanned { get; set; }

        [JsonProperty("media_name")]
        public string MediaName { get; set; }

        [JsonProperty("media_display_name")]
        public string MediaDisplayName { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_title")]
        public string MediaTitle { get; set; }

        [JsonProperty("media_description")]
        public string MediaDescription { get; set; }

        [JsonProperty("media_description_md")]
        public object MediaDescriptionMd { get; set; }

        [JsonProperty("media_tags")]
        public string MediaTags { get; set; }

        [JsonProperty("media_duration")]
        public string MediaDuration { get; set; }

        [JsonProperty("media_bg_image")]
        public object MediaBgImage { get; set; }

        [JsonProperty("media_views")]
        public string MediaViews { get; set; }

        [JsonProperty("media_views_daily")]
        public string MediaViewsDaily { get; set; }

        [JsonProperty("media_views_weekly")]
        public string MediaViewsWeekly { get; set; }

        [JsonProperty("media_views_monthly")]
        public string MediaViewsMonthly { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("category_name_short")]
        public object CategoryNameShort { get; set; }

        [JsonProperty("category_seo_key")]
        public string CategorySeoKey { get; set; }

        [JsonProperty("category_viewers")]
        public string CategoryViewers { get; set; }

        [JsonProperty("category_media_count")]
        public string CategoryMediaCount { get; set; }

        [JsonProperty("category_channels")]
        public object CategoryChannels { get; set; }

        [JsonProperty("category_logo_small")]
        public object CategoryLogoSmall { get; set; }

        [JsonProperty("category_logo_large")]
        public string CategoryLogoLarge { get; set; }

        [JsonProperty("category_updated")]
        public string CategoryUpdated { get; set; }

        [JsonProperty("team_name")]
        public object TeamName { get; set; }

        [JsonProperty("media_start_in_sec")]
        public string MediaStartInSec { get; set; }

        [JsonProperty("media_duration_format")]
        public string MediaDurationFormat { get; set; }

        [JsonProperty("media_thumbnail")]
        public string MediaThumbnail { get; set; }

        [JsonProperty("media_thumbnail_large")]
        public string MediaThumbnailLarge { get; set; }

        [JsonProperty("channel")]
        public GetVideosChannel Channel { get; set; }
    }
}
