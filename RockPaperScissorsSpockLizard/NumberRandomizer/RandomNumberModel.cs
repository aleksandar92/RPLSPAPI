using System.Text.Json.Serialization;

namespace RockPaperScissorsSpockLizard.NumberRandomizer;

public class RandomNumberModel
{
    [JsonPropertyName("random_number")]
    public int RandomNumber { get; set; }
}
