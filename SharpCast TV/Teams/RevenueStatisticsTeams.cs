using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SharpCastTV
{
    public class TeamsRevenueStatistics
    {
        [JsonProperty("team")]
        public TeamsTeamInfo TeamsTeamInfo { get; set; }

        [JsonProperty("request")]
        public TeamRevenuesRequestInfo TeamRevenuesRequestInfo { get; set; }
    }

    public class TeamRevenuesRequestInfo
    {
        [JsonProperty("this")]
        public string This { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class TeamRevenuesSummary
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TeamRevenuesPlan
    {
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        [JsonProperty("plan_group_id")]
        public object PlanGroupId { get; set; }

        [JsonProperty("plan_user_id")]
        public string PlanUserId { get; set; }
        
        [JsonProperty("plan_countries")]
        public string PlanCountries { get; set; }

        [JsonProperty("plan_cpm")]
        public string PlanCpm { get; set; }

        [JsonProperty("plan_currency")]
        public string PlanCurrency { get; set; }

        [JsonProperty("plan_date_added")]
        public string PlanDateAdded { get; set; }
    }

    public class TeamsSummary
    {
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        [JsonProperty("total_earnings")]
        public double TotalEarnings { get; set; }

        [JsonProperty("max_earnings")]
        public object MaxEarnings { get; set; }

        [JsonProperty("sub_earnings")]
        public double SubEarnings { get; set; }

        [JsonProperty("live_earnings")]
        public double LiveEarnings { get; set; }

        [JsonProperty("video_earnings")]
        public double VideoEarnings { get; set; }
    }

    public class TeamMembersStatistics
    {
        [JsonProperty("summary")]
        public TeamsSummary TeamSummary { get; set; }

        [JsonProperty("timeline")]
        public List<List<EarningsInfo>> TimelineEarnings { get; set; }
        
        [JsonProperty("daily")]
        public Dictionary<string, EarningsInfo> TeamDaily { get; set; }
    }

    public class TeamInfo
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
        public object GroupCover { get; set; }

        [JsonProperty("members_total")]
        public int MembersTotal { get; set; }
    }

    public class TeamsRevenuesSummary
    {
        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("total_earnings")]
        public int TotalEarnings { get; set; }

        [JsonProperty("max_earnings")]
        public int MaxEarnings { get; set; }

        [JsonProperty("sub_earnings")]
        public int SubEarnings { get; set; }

        [JsonProperty("live_earnings")]
        public int LiveEarnings { get; set; }

        [JsonProperty("video_earnings")]
        public int VideoEarnings { get; set; }
    }

    public class TeamMembers
    {
        [JsonProperty("summary")]
        public TeamsSummary TeamSummary { get; set; }

        [JsonProperty("followers")]
        public string Followers { get; set; }

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

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("timeline")]
        public IList<IList<long>> Timeline { get; set; }

        [JsonProperty("daily")]
        public Dictionary<string, EarningsInfo> TeamDaily { get; set; }

        [JsonProperty("summary")]
        public TeamRevenuesSummary TeamRevenueSummary { get; set; }
    }

    public class TeamsTeamInfo
    {
        [JsonProperty("revenues")]
        public TeamMembersStatistics TeamMembersStatistics { get; set; }

        [JsonProperty("info")]
        public TeamInfo TeamInfo { get; set; }

        [JsonProperty("members")]
        public IList<TeamMembers> TeamMembers { get; set; }

        [JsonProperty("summary")]
        public TeamRevenuesSummary TeamRevenuesSummary { get; set; }
    }
}

// TODO: Compare code to Channel/Statistics/RevenueStatistics.cs

/*
    public class RootObject
    {
        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }
    }

    public class Request
    {
        [JsonProperty("this")]
        public string This { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class Summary
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class Plan
    {
        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("plan_name")]
        public string PlanName { get; set; }

        [JsonProperty("plan_group_id")]
        public string PlanGroupId { get; set; }

        [JsonProperty("plan_user_id")]
        public object PlanUserId { get; set; }

        [JsonProperty("plan_countries")]
        public string PlanCountries { get; set; }

        [JsonProperty("plan_cpm")]
        public string PlanCpm { get; set; }

        [JsonProperty("plan_currency")]
        public string PlanCurrency { get; set; }

        [JsonProperty("plan_date_added")]
        public string PlanDateAdded { get; set; }
    }

    public class 20151010
    {
        [JsonProperty("earnings")]
        public int Earnings { get; set; }
    }

    public class Daily
    {
        [JsonProperty("2015-10-10")]
        public 20151010 20151010 { get; set; }
    }

    public class 1
    {
        [JsonProperty("summary")]
        public  Summary { get; set; }

        [JsonProperty("timeline")]
        public IList<IList<long>> Timeline { get; set; }

        [JsonProperty("daily")]
        public Daily Daily { get; set; }
    }

    public class Members
    {
        [JsonProperty("1")]
        public 1 1 { get; set; }
    }

    public class Revenues
    {
        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        [JsonProperty("plans")]
        public IList<Plan> Plans { get; set; }

        [JsonProperty("members")]
        public Members Members { get; set; }
    }

    public class Info
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
        public object GroupCover { get; set; }

        [JsonProperty("members_total")]
        public int MembersTotal { get; set; }
    }

    public class Member
    {
        [JsonProperty("followers")]
        public string Followers { get; set; }

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

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("revenues")]
        public  Revenues { get; set; }
    }

    public class Team
    {
        [JsonProperty("revenues")]
        public Revenues Revenues { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("members")]
        public IList<Member> Members { get; set; }

        [JsonProperty("summary")]
        public  Summary { get; set; }
    } 
 */
