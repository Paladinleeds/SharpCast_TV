using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// This might not be properly formatted. Will request help for this.

namespace SharpCastTV
{
    public class Esports
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("livestream")]
        public IList<Livestream> Livestream { get; set; }
    }

    public class EsportsChannel
    {
        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("channel_link")]
        public string ChannelLink { get; set; }
    }

    public class Images
    {
        [JsonProperty("square")]
        public string Square { get; set; }

        [JsonProperty("circle")]
        public string Circle { get; set; }

        [JsonProperty("rectangle")]
        public string Rectangle { get; set; }
    }

    public class Game
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("long_title")]
        public string LongTitle { get; set; }

        [JsonProperty("deleted_at")]
        public object DeletedAt { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("backdrop")]
        public string Backdrop { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class Prizepool
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("second")]
        public string Second { get; set; }

        [JsonProperty("third")]
        public string Third { get; set; }
    }

    public class Links
    {
        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("wiki")]
        public string Wiki { get; set; }

        [JsonProperty("youtube")]
        public string Youtube { get; set; }
    }

    public class Tournament
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("start")]
        public DateTime Start { get; set; }

        [JsonProperty("end")]
        public object End { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("admin_note_id")]
        public object AdminNoteId { get; set; }

        [JsonProperty("short_title")]
        public string ShortTitle { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("images")]
        public string Images { get; set; }

        [JsonProperty("prizepool")]
        public Prizepool Prizepool { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("game")]
        public string Game { get; set; }
    }

    public class Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("images")]
        public string Images { get; set; }
    }

    public class TeamA
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("images")]
        public string Images { get; set; }

        [JsonProperty("is_team")]
        public bool IsTeam { get; set; }
    }

    public class TeamB
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        [JsonProperty("images")]
        public string Images { get; set; }

        [JsonProperty("is_team")]
        public bool IsTeam { get; set; }
    }

    public class Score
    {
        [JsonProperty("teamA")]
        public int TeamA { get; set; }

        [JsonProperty("teamB")]
        public int TeamB { get; set; }
    }

    public class EsportSchedule
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("start")]
        public DateTime Start { get; set; }

        [JsonProperty("end")]
        public DateTime End { get; set; }

        [JsonProperty("bestOf")]
        public int BestOf { get; set; }

        [JsonProperty("game")]
        public Game Game { get; set; }

        [JsonProperty("tournament")]
        public Tournament Tournament { get; set; }

        [JsonProperty("teamA")]
        public TeamA TeamA { get; set; }

        [JsonProperty("teamB")]
        public TeamB TeamB { get; set; }

        [JsonProperty("score")]
        public Score Score { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("live")]
        public bool Live { get; set; }
    }

    public class Livestream
    {
        [JsonProperty("media_display_name")]
        public string MediaDisplayName { get; set; }

        [JsonProperty("media_status")]
        public string MediaStatus { get; set; }

        [JsonProperty("media_name")]
        public string MediaName { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("category_seo_key")]
        public string CategorySeoKey { get; set; }

        [JsonProperty("media_views")]
        public string MediaViews { get; set; }

        [JsonProperty("media_countries")]
        public IList<string> MediaCountries { get; set; }

        [JsonProperty("media_live_since")]
        public string MediaLiveSince { get; set; }

        [JsonProperty("media_is_live")]
        public string MediaIsLive { get; set; }

        [JsonProperty("user_logo")]
        public string UserLogo { get; set; }

        [JsonProperty("user_logo_small")]
        public string UserLogoSmall { get; set; }

        [JsonProperty("user_partner")]
        public string UserPartner { get; set; }

        [JsonProperty("media_offline_id")]
        public object MediaOfflineId { get; set; }

        [JsonProperty("media_id")]
        public string MediaId { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("media_thumbnail")]
        public string MediaThumbnail { get; set; }

        [JsonProperty("media_thumbnail_large")]
        public string MediaThumbnailLarge { get; set; }

        [JsonProperty("channel")]
        public EsportsChannel Channel { get; set; }

        [JsonProperty("esport")]
        public EsportSchedule Esport { get; set; }
    }
}
