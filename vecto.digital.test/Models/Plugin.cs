namespace vecto.digital.test.Models;

internal class Plugin
{
    public Resize Resize { get; set; } = new();
    public Blur Blur { get; set; } = new();
    public GrayScale Grayscale { get; set; } = new();

}