using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    class GetTeamsOfUser
    {
        [JsonProperty("teams")]
        public IList<Team> Teams { get; set; }
    }

    public class GetTeamsOfUserInfo
    {
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("founder_name")]
        public string FounderName { get; set; }

        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("group_display_name")]
        public string GroupDisplayName { get; set; }

        [JsonProperty("group_text")]
        public string GroupText { get; set; }

        [JsonProperty("group_logo_small")]
        public string GroupLogoSmall { get; set; }

        [JsonProperty("group_logo_large")]
        public string GroupLogoLarge { get; set; }

        [JsonProperty("group_cover")]
        public string GroupCover { get; set; }

        [JsonProperty("members_total")]
        public int MembersTotal { get; set; }

        [JsonProperty("group_role")]
        public string GroupRole { get; set; }

        [JsonProperty("group_accepted")]
        public bool GroupAccepted { get; set; }

        [JsonProperty("group_default")]
        public int GroupDefault { get; set; }
    }

    public class GetTeamsOfUserMember
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

        [JsonProperty("admin")]
        public string Admin { get; set; }

        [JsonProperty("enabled")]
        public string Enabled { get; set; }

        [JsonProperty("group_role")]
        public string GroupRole { get; set; }

        [JsonProperty("group_accepted")]
        public bool GroupAccepted { get; set; }
    }

    public class GetTeamsOfUserTeam
    {
        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("members")]
        public IList<Member> Members { get; set; }
    }
}
