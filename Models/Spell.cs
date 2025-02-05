using SkyfallAPI.Models.Enums;

namespace SkyfallAPI.Models;

public class Spell
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public ActionTypeEnum Action { get; set; }
    public int Cost { get; set; }
    public string? Description { get; set; }
    public string? Execution { get; set; }
    public string? Range { get; set; }
    public string? Target { get; set; }
    public string? Components { get; set; }
    public string? Duration { get; set; }
    public string? Attack { get; set; }
    public string? Effect { get; set; }

    //public string Layer { get; set; }
    //public string Tags { get; set; }
}
