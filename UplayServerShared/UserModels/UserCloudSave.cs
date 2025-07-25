﻿namespace UplayServerShared.UserModels;

public class UserCloudSave : UserBase
{
    public uint UplayId { get; set; }
    public uint SaveId { get; set; }
    public string SaveName { get; set; } = string.Empty;
}
