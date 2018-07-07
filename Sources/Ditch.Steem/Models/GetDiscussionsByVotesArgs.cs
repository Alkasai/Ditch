using Newtonsoft.Json;

namespace Ditch.Steem.Models
{
    /// <inheritdoc />
    /// <summary>
    /// get_discussions_by_votes_args
    /// libraries\plugins\apis\tags_api\include\steem\plugins\tags_api\tags_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GetDiscussionsByVotesArgs : DiscussionQuery
    {
    }
}
