namespace vecto.digital.test.Decorators;

internal class ResizeDecorator : Decorator
{
    private readonly Resize _resize;

    internal ResizeDecorator(Component component, Resize pluginResize)
        : base(component)
    {
        _resize = pluginResize;
    }

    internal override string Operation()
    {
        if (_resize.ToResize)
            return $"resize to {_resize.Pixels} pixels, {base.Operation()}";

        return base.Operation();
    }
}
