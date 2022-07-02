namespace vecto.digital.test.Decorators;

internal class BlurDecorator : Decorator
{
    private readonly Blur _blur;

    internal BlurDecorator(Component component, Blur pluginblur)
        : base(component)
    {
        _blur = pluginblur;
    }

    internal override string Operation()
    {
        if (_blur.ToBlur)
            return $"add blur {_blur.Pixels} pixels size, {base.Operation()}";

        return base.Operation();
    }
}