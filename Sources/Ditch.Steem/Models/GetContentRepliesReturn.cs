using Newtonsoft.Json;

namespace Ditch.Steem.Models
{
    /// <inheritdoc />
    /// <summary>
    /// get_content_replies_return
    /// libraries\plugins\apis\tags_api\include\steem\plugins\tags_api\tags_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GetContentRepliesReturn : DiscussionQueryResult
    {
    }
}
