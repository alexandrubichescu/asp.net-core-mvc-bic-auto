namespace BicAuto.Models;
public class Auto
{
    public int AutoId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Model { get; set; }
    public decimal Price { get; set; }
    public string? FabricationDate { get; set; }
    public string? Features { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageThumbnailUrl { get; set; }
    public bool IsAutoOfTheYear { get; set; }
    public bool InStock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = default!;
}

