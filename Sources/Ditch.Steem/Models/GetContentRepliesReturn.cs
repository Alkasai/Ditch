using Newtonsoft.Json;
using System;

namespace Ditch.Steem.Models
{
    /// <inheritdoc />
    /// <summary>
    /// get_content_replies_return
    /// libraries\plugins\apis\tags_api\include\steem\plugins\tags_api\tags_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GetContentRepliesReturn
    {
        [JsonProperty("percent_steem_dollars")]
        public int PercentSteemDollars { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("permlink")]
        public string Permlink { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("curator_payout_value")]
        public string CuratorPayoutValue { get; set; }
        [JsonProperty("max_accepted_payout")]
        public string MaxAcceptedPayout { get; set; }
        [JsonProperty("cashout_time")]
        public DateTime CashoutTime { get; set; }
        [JsonProperty("promoted")]
        public string Promoted { get; set; }
        [JsonProperty("parent_author")]
        public string ParentAuthor { get; set; }
        [JsonProperty("parent_permlink")]
        public string ParentPermlink { get; set; }
        [JsonProperty("post_id")]
        public int PostId { get; set; }
        [JsonProperty("body_length")]
        public int BodyLength { get; set; }
        [JsonProperty("last_payout")]
        public DateTime Lastpayout { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("net_rshares")]
        public long NetRshares { get; set; }
        [JsonProperty("active_votes")]
        public Active_Votes[] ActiveVotes { get; set; }
        [JsonProperty("last_update")]
        public DateTime LastUpdate { get; set; }
        [JsonProperty("beneficiaries")]
        public object[] Beneficiaries { get; set; }
        [JsonProperty("pending_payout_value")]
        public string PendingPayoutValue { get; set; }
        [JsonProperty("children")]
        public int Children { get; set; }
        [JsonProperty("root_title")]
        public string RootTitle { get; set; }
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        [JsonProperty("depth")]
        public int Depth { get; set; }
        [JsonProperty("total_payout_value")]
        public string TotalPayoutValue { get; set; }
        [JsonProperty("author")]
        public string Author { get; set; }
        [JsonProperty("replies")]
        public object[] Replies { get; set; }
        [JsonProperty("author_reputation")]
        public long AuthorReputation { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("json_metadata")]
        public string JsonMetadata { get; set; }
    }

    public class Active_Votes
    {
        public string rshares { get; set; }
        public string voter { get; set; }
        public string percent { get; set; }
        public string reputation { get; set; }
    }
}
