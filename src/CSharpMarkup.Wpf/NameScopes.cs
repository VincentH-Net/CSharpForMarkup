using System.Runtime.CompilerServices;

namespace CSharpMarkup.Wpf
{
    public static class NameScopeExtensions
    {
        static System.Collections.Generic.List<(string name, System.Windows.Threading.DispatcherObject scopedElement)> namescopeRegistrations = new(20);

        public static TDispatcherObject xName<TDispatcherObject>(this TDispatcherObject dispatcherObject, object? nameExpression = null, [CallerArgumentExpression("nameExpression")] string? nameExpressionString = default) where TDispatcherObject : DispatcherObject
        {
            namescopeRegistrations.Add((Helpers.NameExpressionToName(nameExpressionString), dispatcherObject.UI));
            return dispatcherObject;
        }

        public static TFrameworkElement WithNameScope<TFrameworkElement>(this TFrameworkElement frameworkElement) where TFrameworkElement : FrameworkElement
        {
            System.Windows.NameScope.SetNameScope(frameworkElement.UI, new System.Windows.NameScope());

            // Since child elements in C# are created before their parent element (which is the other way around in XAML),
            // at this point any calls to xName for this namescope have been executed.
            // So we can add all names to the namescope here.
            foreach ((var name, var scopedElement) in namescopeRegistrations)
                frameworkElement.UI.RegisterName(name, scopedElement);
            namescopeRegistrations.Clear();

            return frameworkElement;
        }
    }
}