using Newtonsoft.Json;

namespace RestSharp_Automation.DTO
{
    public class CreateUserResponseDTO
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("job")]
        public string? Job { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }
    }
    public partial class CreateUserDTO
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        [JsonProperty("job")]
        public string? Job { get; set; }
    }
}
