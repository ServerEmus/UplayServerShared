namespace UplayServerShared.ApiModels;

public class AppSettings
{
    [LiteDB.BsonId]
    public Guid ApplicationId { get; set; } = Guid.Empty;
    public Dictionary<string, object> Parameters { get; set; } = [];
    public Dictionary<string, object> Configuration { get; set; } = [];
    public string FallbackDirectory { get; set; } = string.Empty;
}
