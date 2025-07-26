
using System.Text.Json.Serialization;

namespace UplayServerShared.UserModels;

public class UserStatCard : UserBase
{
    [JsonPropertyName("obj")]
    public string Obj { get; set; } = string.Empty;

    [JsonPropertyName("periodDuration")]
    public string PeriodDuration { get; set; } = string.Empty;

    [JsonPropertyName("periodLifespan")]
    public string PeriodLifespan { get; set; } = string.Empty;

    [JsonPropertyName("periodLength")]
    public string PeriodLength { get; set; } = string.Empty;

    [JsonPropertyName("pastPeriods")]
    public List<object> PastPeriods { get; set; } = [];

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = string.Empty;

    /// <summary>
    /// This can be: Integer, LongTimespan, Percentage
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; set; } = string.Empty;

    [JsonPropertyName("lastModified")]
    public DateTimeOffset LastModified { get; set; }

    [JsonPropertyName("locale")]
    public string Locale { get; set; } = string.Empty;

    [JsonPropertyName("ordinal")]
    public long Ordinal { get; set; }

    /// <summary>
    /// This can be: Best, Cumulative, Tier
    /// </summary>
    [JsonPropertyName("semantic")]
    public string Semantic { get; set; } = string.Empty;

    /// <summary>
    /// This can be: Descending, Ascending
    /// </summary>
    [JsonPropertyName("sort")]
    public string Sort { get; set; } = string.Empty;

    [JsonPropertyName("startDate")]
    public DateTimeOffset StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public string EndDate { get; set; } = string.Empty;

    [JsonPropertyName("statName")]
    public string StatName { get; set; } = string.Empty;

    /// <summary>
    /// This can be: Seconds, (Empty string)
    /// </summary>
    [JsonPropertyName("unit")]
    public string Unit { get; set; } = string.Empty;

    [JsonPropertyName("value")]
    public string Value { get; set; } = string.Empty;
}
