using System.Collections.Generic;

namespace waldo.Domain.ApiModels
{
    public class GroupSearchResponse
    {
        public List<SearchResponse> SearchResponses { get; set; }
    }
}