namespace vecto.digital.test.Decorators;

internal class GrayScaleDecorator : Decorator
{
    private readonly GrayScale _grayScale;

    internal GrayScaleDecorator(Component component, GrayScale pluginGrayScale)
        : base(component)
    {
        _grayScale = pluginGrayScale;
    }

    internal override string Operation()
    {
        if (_grayScale.ToConvert)
            return $"convert to grayscale, {base.Operation()}";

        return base.Operation();
    }
}
