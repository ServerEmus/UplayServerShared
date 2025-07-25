namespace UplayServerShared.ProductModels;

public class ProductStore
{
    [LiteDB.BsonId]
    public uint ProductId { get; set; }
    public string Configuration { get; set; } = string.Empty;
    public string Reference { get; set; } = string.Empty;
    public string UserBlob { get; set; } = string.Empty;
    public int Partner { get; set; }
    public List<uint> OwnershipAssociations { get; set; } = [];
    public List<uint> Associations { get; set; } = [];
    public int Type { get; set; }
}
