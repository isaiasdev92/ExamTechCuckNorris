using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTech.Application.Models
{

    public class ItemSearch
    {
        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CuckNorriseJokeResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("result")]
        public List<ItemSearch> Result { get; set; }
    }

}
