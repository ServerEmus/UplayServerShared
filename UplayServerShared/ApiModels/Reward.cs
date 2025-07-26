using System.Text.Json.Serialization;

namespace UplayServerShared.ApiModels;

public class Reward
{
    [JsonPropertyName("rewardId")]
    public Guid RewardId { get; set; }

    [JsonPropertyName("spaceId")]
    public Guid SpaceId { get; set; }

    [JsonPropertyName("purchaseQuantity")]
    public long PurchaseQuantity { get; set; } = 1;

    [JsonPropertyName("currentUnitsPrice")]
    public long CurrentUnitsPrice { get; set; } = 10;

    [JsonPropertyName("completedConditions")]
    public List<object> CompletedConditions { get; set; } = [];

    [JsonPropertyName("limitReachedDetails")]
    public List<string> LimitReachedDetails { get; set; } = [];

    [JsonPropertyName("lockedDetails")]
    public List<object> LockedDetails { get; set; } = [];

    [JsonPropertyName("source")]
    public string Source { get; set; } = "UbiConnect";
}
