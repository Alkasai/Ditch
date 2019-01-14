using Newtonsoft.Json;

namespace Ditch.Steem.Models
{
    /// <summary>
    /// get_followers_return
    /// libraries\plugins\apis\follow_api\include\steem\plugins\follow_api\follow_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GetFollowersReturn
    {
        [JsonProperty("what")]
        public string[] What { get; set; }
        [JsonProperty("following")]
        public string Following { get; set; }
        [JsonProperty("follower")]
        public string Follower { get; set; }
    }
}