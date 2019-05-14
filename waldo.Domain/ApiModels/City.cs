using System.Diagnostics.Contracts;
using Newtonsoft.Json;

namespace waldo.Domain.ApiModels
{
    public class City
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
    }
}