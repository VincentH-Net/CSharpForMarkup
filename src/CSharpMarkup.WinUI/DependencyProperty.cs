using Xaml = Microsoft.UI.Xaml;
using BindingOperations = Microsoft.UI.Xaml.Data.BindingOperations;

namespace CSharpMarkup.WinUI
{
    public class DependencyProperty<TDependencyObject, TPropertyValue> where TDependencyObject : DependencyObject
    {
        static DependencyProperty<TDependencyObject, TPropertyValue> instance;
        // This class is not thread-safe by design - we don't need that so avoid the overhead.
        // 
        // Rationale:
        // As long as all markup is constructed on the same (UI) thread, no more than one instance of each 
        // constructed variation of DependencyProperty will ever be in use at the same time.
        //
        // E.g. for .TextAlignment() .Left() the DependencyProperty<TLabel, TextAlignment> instance usage starts in 
        // .TextAlignment() and ends after .Left().
        // This is synchronous code, so no chance of other threads using a DependencyProperty at the same time.
        // So we really only need a single instance during the entire app lifetime.

        // Because all layouts have their child controls built in the layout factory helper, 
        // and any DependencyProperty on a layout will only be started after the layout factory helper finishes,
        // even e.g. a StackPanel that uses a <StackPanel, Orientation> DependencyProperty and that contains
        // another StackPanel that uses the same <StackPanel, Orientation> DependencyProperty instance, 
        // will not cause overlapping use of that DependencyProperty instance.

        // However, if we create chain classes that can be nested - so a chain within a chain e.g. .Color() .Dark() .Blue() - 
        // then at least each chain nesting level does need a separate static instance (so 2 instances in this example).
        // Note that by definition, a chain cannot contain a suhchain with the same TParent, TChild combination; 
        // that would still be just a single TParent, TChild chain.

        public static DependencyProperty<TDependencyObject, TPropertyValue> Get(TDependencyObject element, Xaml.DependencyProperty property)
        {
            if (instance == null) instance = new DependencyProperty<TDependencyObject, TPropertyValue>();
            instance.Target = element;
            instance.UI = property;
            return instance;
        }

        protected DependencyProperty() { }

        public TDependencyObject Target { get; private set; }
        public Xaml.DependencyProperty UI { get; private set; }

        internal TDependencyObject Set(TPropertyValue value) { Target.UI.SetValue(UI, value); return Target; }
        internal TDependencyObject SetBinding(Xaml.Data.BindingBase binding) { BindingOperations.SetBinding(Target.UI, UI, binding); return Target; }
    }
}