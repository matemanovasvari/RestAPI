namespace REST_sample_01_net8.Models;

public class MotorcycleUpdateModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}