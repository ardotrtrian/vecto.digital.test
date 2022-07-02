namespace vecto.digital.test.Decorators;

internal class Decorator : Component
{
    protected Component _component;

    internal Decorator(Component component)
    {
        _component = component;
    }

    internal override string Operation()
    {
        if (_component is not null)
            return _component.Operation();

        return string.Empty;
    }
}
