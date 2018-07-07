using Newtonsoft.Json;

namespace Ditch.Golos.Models
{
    /// <summary>
    /// account_reputation
    /// plugins\follow\include\golos\plugins\follow\follow_api_object.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountReputation
    {

        /// <summary>
        /// API name: account
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("account")]
        public string Account {get; set;}

        /// <summary>
        /// API name: reputation
        /// 
        /// </summary>
        /// <returns>API type: share_type</returns>
        [JsonProperty("reputation", NullValueHandling = NullValueHandling.Ignore)]
        public object Reputation {get; set;}
    }
}
