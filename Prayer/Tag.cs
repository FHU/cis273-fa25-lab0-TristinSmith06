
namespace Prayer;

public record class Tag
{
    public string Name { get; set; } = "";
    public string Color { get; set; } = "";

    public string Icon { get; set; } = "";

    public override string ToString()
    {
        return $"{Name}";
    }
}

