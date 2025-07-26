using System.Text.Json.Serialization;

namespace UplayServerShared.UserModels;

public class UserReward : UserBase
{
    [JsonPropertyName("rewardId")]
    public Guid RewardId { get; set; }

    [JsonPropertyName("spaceId")]
    public Guid SpaceId { get; set; }

    [JsonPropertyName("purchasedAt")]
    public DateTimeOffset PurchasedAt { get; set; } = DateTimeOffset.Now.AddDays(-10);

    [JsonPropertyName("status")]
    public string Status { get; set; } = "LimitReached";
}
