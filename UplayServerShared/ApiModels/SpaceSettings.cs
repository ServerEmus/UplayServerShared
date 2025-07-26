namespace UplayServerShared.ApiModels;

public class SpaceSettings
{
    [LiteDB.BsonId]
    public Guid ApplicationId { get; set; } = Guid.Empty;
    public Dictionary<string, object> Parameters { get; set; } = [];
    public List<object> Challenges { get; set; } = [];
    public List<Reward> Rewards { get; set; } = [];
    public string FallbackDirectory { get; set; } = string.Empty;
}
