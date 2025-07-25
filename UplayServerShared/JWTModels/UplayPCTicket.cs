using System.Text.Json.Serialization;

namespace UplayServerShared.JWTModels;

public class UplayPCTicket : BaseJWT
{
    [JsonPropertyName("uplay_id")]
    public int UplayId { get; set; }

    [JsonPropertyName("platform")]
    public int Platform { get; set; }
}
