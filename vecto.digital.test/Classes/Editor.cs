namespace vecto.digital.test.Classes;

internal class Editor
{
    public static void Apply(Plugin plugin)
    {
        var simple = new ConcreteComponent();

        var scaled = new GrayScaleDecorator(simple, plugin.Grayscale);

        var blurred = new BlurDecorator(scaled, plugin.Blur);

        var resized = new ResizeDecorator(blurred, plugin.Resize);

        Console.WriteLine(resized?.Operation());
    }
}