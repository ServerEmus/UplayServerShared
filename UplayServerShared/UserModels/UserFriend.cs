﻿namespace UplayServerShared.UserModels;

public class UserFriend : UserBase
{
    public Guid IdOfFriend { get; set; }
    public string? Nickname { get; set; }
    public bool IsFavorite { get; set; } = false;
    public bool IsBlacklisted { get; set; } = false;
    public Uplay.Friends.Relationship.Types.Relation Relation { get; set; }
}
