using Ditch.Core.Models;
using Newtonsoft.Json;

namespace Ditch.Golos.Models
{
    /// <summary>
    /// blog_entry
    /// plugins\follow\include\golos\plugins\follow\follow_api_object.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BlogEntry
    {

        /// <summary>
        /// API name: author
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// API name: permlink
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("permlink")]
        public string Permlink { get; set; }

        /// <summary>
        /// API name: blog
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("blog")]
        public string Blog { get; set; }

        /// <summary>
        /// API name: reblog_on
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("reblog_on")]
        public TimePointSec ReblogOn { get; set; }

        /// <summary>
        /// API name: entry_id
        /// = 0;
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("entry_id")]
        public uint EntryId { get; set; }

        /// <summary>
        /// API name: reblog_title
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("reblog_title")]
        public string ReblogTitle { get; set; }

        /// <summary>
        /// API name: reblog_body
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("reblog_body")]
        public string ReblogBody { get; set; }

        /// <summary>
        /// API name: reblog_json_metadata
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("reblog_json_metadata")]
        public string ReblogJsonMetadata { get; set; }
    }
}
