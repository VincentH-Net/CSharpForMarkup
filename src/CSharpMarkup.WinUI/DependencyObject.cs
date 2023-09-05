using System;
using System.Runtime.CompilerServices;
using Xaml = Microsoft.UI.Xaml;
using BindingMode = Microsoft.UI.Xaml.Data.BindingMode;
using IValueConverter = Microsoft.UI.Xaml.Data.IValueConverter;
using UpdateSourceTrigger = Microsoft.UI.Xaml.Data.UpdateSourceTrigger;

namespace CSharpMarkup.WinUI
{
    public static partial class Helpers
    {
        // Note that in contrast to WPF, WinUI 3 does not support bindings in a style setter; the corresponding .Bind() extension methods are not present in CSharpMarkup.WinUI
        // Source: https://docs.microsoft.com/en-us/windows/winui/api/microsoft.ui.xaml.setter?view=winui-3.0#migration-notes

        const string bindingContextPath = ""; // TODO: Find framework static var for this

        public static string BindingExpressionToPath(string pathExpression)
        {
            if (pathExpression == null) return bindingContextPath;

            // Allow to identify the viewmodel part of the expression with parenthesis
            // <path expression> = <viewmodel>.<path> || (<viewmodel expression>).<path>, where <path> can contain dots
            // e.g. .Bind ((vm.SelectedTweet).Title) => "Title", .Bind ((vm.SelectedTweet).Author.Name) => "Author.Name"
            int endOfViewModelExpression = pathExpression.IndexOf('.', pathExpression.LastIndexOf(')') + 1) + 1;

            return pathExpression
                .Substring(endOfViewModelExpression) // Remove the viewmodel part from the binding string
                .Replace("?", "")                    // Allow .Bind (tweet?.Title) where tweet is a null instance field used for binding only
                .Trim('"', '@', ' ', '\t');          // Allow .Bind ("ILikeStringLiterals") => "ILikeStringLiterals"
        }

        public static TUI AppResource<TUI>(string name) => (TUI)Xaml.Application.Current.Resources[name];
    }

    public interface IUI<TUI> : IAnyUI<TUI> where TUI : Xaml.DependencyObject { }

    public interface IAnyUI<TUI> : IAnyUI // Support non-DependencyObject UI types, e.g. an interface
    {
        TUI UI { get; }
    }

    public interface IAnyUI { }

#if !WINUI
    public partial class DependencyObject : IUI<Xaml.DependencyObject>
    {
        public Xaml.DependencyObject UI { get; protected set; }

        protected DependencyObject() { }
    }
#endif

    /// <summary>
    /// Allows to specify <see cref="CSharpMarkup.WinUI"/> types (e.g. <see cref="TextBlock"/>) as well as commonly used built-in C# / UI types (e.g. <see cref="string"/> or <see cref="Xaml.Thickness"/>).
    /// </summary>
    /// <remarks>For types not supported by implicit conversion, use the <see cref="UIObject(object)"/> contructor, e.g.: <code>new (FontCapitals.Normal)</code></remarks>
    public class UIObject : IAnyUI<object>
    {
        public object UI { get; }

        // Built-in C# types
        public static implicit operator UIObject(bool value) => new UIObject(value);
        public static implicit operator UIObject(int value) => new UIObject(value);
        public static implicit operator UIObject(float value) => new UIObject(value);
        public static implicit operator UIObject(double value) => new UIObject(value);
        public static implicit operator UIObject(char value) => new UIObject(value);
        public static implicit operator UIObject(string value) => new UIObject(value);

        // Struct types
        public static implicit operator UIObject(Xaml.CornerRadius value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.Duration value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.GridLength value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.Thickness value) => new UIObject(value);
        public static implicit operator UIObject(Windows.UI.Color value) => new UIObject(value);
        public static implicit operator UIObject(Windows.UI.Text.FontWeight value) => new UIObject(value);
        public static implicit operator UIObject(Windows.Foundation.Point value) => new UIObject(value);
        public static implicit operator UIObject(Windows.Foundation.Rect value) => new UIObject(value);
        public static implicit operator UIObject(Windows.Foundation.Size value) => new UIObject(value);

        // Enum types
        public static implicit operator UIObject(Windows.UI.Text.FontStretch value) => new UIObject(value);
        public static implicit operator UIObject(Windows.UI.Text.FontStyle value) => new UIObject(value);
        public static implicit operator UIObject(Windows.UI.Text.HorizontalCharacterAlignment value) => new UIObject(value);
        public static implicit operator UIObject(Windows.UI.Text.LineSpacingRule value) => new UIObject(value);
        public static implicit operator UIObject(Windows.UI.Text.LinkType value) => new UIObject(value);
        public static implicit operator UIObject(Windows.UI.Text.VerticalCharacterAlignment value) => new UIObject(value);

        public static implicit operator UIObject(Xaml.FlowDirection value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.HorizontalAlignment value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.LineStackingStrategy value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.TextAlignment value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.TextTrimming value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.TextWrapping value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.VerticalAlignment value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.Visibility value) => new UIObject(value);

        // Non-markup class types
        public static implicit operator UIObject(Xaml.Media.FontFamily value) => new UIObject(value);
        public static implicit operator UIObject(Xaml.Data.Binding value) => new UIObject(value);

        // Markup types
        public static implicit operator UIObject(DependencyObject value) => new UIObject(value.UI);

        /// <summary>Use to specify a value of any type that is not implicitly converted to <see cref="UIObject"/></summary>
        public UIObject(object ui) => UI = ui;
    }

    // Since DependencyObject is the root object of the UI hierarchy, this is a good place to explain why and how a single static instance of a chain is safe:

    // Chains have a separate static instance per class; that instance is also a separate instance of all the ancestor classes of that class.
    // The UI property on that instance is also a separate instance per class. E.g. Button and Brush are separate chain instances which are separate DepencyObject instances.
    // So you can nest those chains without breaking them.
    // However what would break a chain is if you try to nest multiple chains of the same class; then the effect would be that you replace the UI of the parent chain with the child UI.

    // But because we use helper parameters for composition == nesting (of views or of property values), and we are executing on a single thread,
    // we prevent ever nesting chains of the same class.
    // TODO: In debug mode, throw an exception if you start a chain within an Invoke() to prevent nesting. Is that enough? Or can we detect the end of a chain through an assignment? Maybe optional end method only present in unit tests?

    // The language guarantuees that all parameter chains are completed before the parent chain is started, and that only a single parameter chain is evaluated at the same time.
    // So even if we e.g. put a StackPanel in a StackPanel with StackPanel(StackPanel()), this does not break a chain.

    public static partial class DependencyObjectExtensions
    {
        const string bindingContextPath = ""; // TODO: Find framework static var for this
        // TODO: Check how much overhead having all these generics introduces (app size binary bloat in eg wasm?)

        /// <summary>Bind to a specified property</summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static TDependencyObject Bind<TDependencyObject, TPropertyValue>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            object pathExpression = null,
            BindingMode mode = BindingMode.OneWay,
            IValueConverter converter = null,
            object converterParameter = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            TPropertyValue targetNullValue = default,
            TPropertyValue fallbackValue = default,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default
        ) where TDependencyObject : DependencyObject
        => property.BindWithString(
            Helpers.BindingExpressionToPath(pathExpressionString),
            mode,
            converter,
            converterParameter,
            converterLanguage,
            updateSourceTrigger,
            source,
            targetNullValue,
            fallbackValue
        );

        /// <remarks>This overload allows to pass a string <paramref name="path"/> instead of a pathExpression. A pathExpression only uses the part after the last '.', while <paramref name="path"/> allows to specify paths that contain '.'</remarks>
        public static TDependencyObject BindWithString<TDependencyObject, TPropertyValue>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            string path = bindingContextPath,
            BindingMode mode = BindingMode.OneWay,
            IValueConverter converter = null,
            object converterParameter = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            TPropertyValue targetNullValue = default,
            TPropertyValue fallbackValue = default
        ) where TDependencyObject : DependencyObject
        => property.SetBinding(new Microsoft.UI.Xaml.Data.Binding
        {
            Path = new Xaml.PropertyPath(path),
            Mode = mode,
            Converter = converter,
            ConverterParameter = converterParameter,
            //ConverterLanguage = converterLanguage, // TODO: figure out correct default; can't be null
            UpdateSourceTrigger = updateSourceTrigger,
            Source = source,
            // TODO: RelativeSource
            TargetNullValue = targetNullValue,
            FallbackValue = fallbackValue,
        });

        /// <summary>Bind to a specified property with inline conversion</summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static TDependencyObject Bind<TDependencyObject, TPropertyValue, TSource>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            object pathExpression = null,
            BindingMode mode = BindingMode.OneWay,
            Func<TSource, TPropertyValue> convert = null,
            Func<TPropertyValue, TSource> convertBack = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            TPropertyValue targetNullValue = default,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default
        ) where TDependencyObject : DependencyObject
        => property.BindWithString(
            Helpers.BindingExpressionToPath(pathExpressionString),
            mode,
            new FuncConverter<TSource, TPropertyValue, object>(convert, convertBack),
            null,
            converterLanguage,
            updateSourceTrigger,
            source,
            targetNullValue
        );

        /// <summary>Bind to a specified property with inline conversion and conversion parameter</summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static TDependencyObject Bind<TDependencyObject, TPropertyValue, TSource, TParam>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            object pathExpression = null,
            BindingMode mode = BindingMode.OneWay,
            Func<TSource, TParam, TPropertyValue> convert = null,
            Func<TPropertyValue, TParam, TSource> convertBack = null,
            TParam converterParameter = default,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            TPropertyValue targetNullValue = default,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default
        ) where TDependencyObject : DependencyObject
        => property.BindWithString(
            Helpers.BindingExpressionToPath(pathExpressionString),
            mode,
            new FuncConverter<TSource, TPropertyValue, TParam>(convert, convertBack),
            converterParameter,
            converterLanguage,
            updateSourceTrigger,
            source,
            targetNullValue
        );

        /// <summary>Bind to <typeparamref name="TDependencyObject"/>.DefaultBindProperty</summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static TDependencyObject Bind<TDependencyObject>(
            this TDependencyObject target,
            object pathExpression = null,
            BindingMode mode = BindingMode.OneWay,
            IValueConverter converter = null,
            object converterParameter = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            object targetNullValue = default,
            object fallbackValue = default,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default
        ) where TDependencyObject : DependencyObject, IDefaultBindProperty
        => target.BindWithString(
            Helpers.BindingExpressionToPath(pathExpressionString),
            mode,
            converter,
            converterParameter,
            converterLanguage,
            updateSourceTrigger,
            source,
            targetNullValue,
            fallbackValue
        );

        /// <remarks>This overload allows to pass a string <paramref name="path"/> instead of a pathExpression. A pathExpression only uses the part after the last '.', while <paramref name="path"/> allows to specify paths that contain '.'</remarks>
        public static TDependencyObject BindWithString<TDependencyObject>(
            this TDependencyObject target,
            string path = bindingContextPath,
            BindingMode mode = BindingMode.OneWay,
            IValueConverter converter = null,
            object converterParameter = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            object targetNullValue = default,
            object fallbackValue = default
        ) where TDependencyObject : DependencyObject, IDefaultBindProperty
        {
            Xaml.Data.BindingOperations.SetBinding(
                target.UI,
                target.DefaultBindProperty,
                new Microsoft.UI.Xaml.Data.Binding
                {
                    Path = new Xaml.PropertyPath(path),
                    Mode = mode,
                    Converter = converter,
                    ConverterParameter = converterParameter,
                    //ConverterLanguage = converterLanguage, // TODO: figure out correct default; can't be null
                    UpdateSourceTrigger = updateSourceTrigger,
                    Source = source,
                    // TODO: RelativeSource
                    TargetNullValue = targetNullValue,
                    FallbackValue = fallbackValue,
                }
            );
            return target;
        }

        /// <summary>Bind to the default property with inline conversion</summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static TDependencyObject Bind<TDependencyObject, TPropertyValue, TSource>(
            this TDependencyObject target,
            object pathExpression = null,
            BindingMode mode = BindingMode.OneWay,
            Func<TSource, TPropertyValue> convert = null,
            Func<TPropertyValue, TSource> convertBack = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            TPropertyValue targetNullValue = default,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default
        ) where TDependencyObject : DependencyObject, IDefaultBindProperty
        => target.BindWithString(
            Helpers.BindingExpressionToPath(pathExpressionString),
            mode,
            new FuncConverter<TSource, TPropertyValue, object>(convert, convertBack),
            null,
            converterLanguage,
            updateSourceTrigger,
            source,
            targetNullValue
        );

        /// <summary>Bind to the default property with inline conversion and conversion parameter</summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static TDependencyObject Bind<TDependencyObject, TPropertyValue, TSource, TParam>(
            this TDependencyObject target,
            object pathExpression = null,
            BindingMode mode = BindingMode.OneWay,
            Func<TSource, TParam, TPropertyValue> convert = null,
            Func<TPropertyValue, TParam, TSource> convertBack = null,
            TParam converterParameter = default,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            TPropertyValue targetNullValue = default,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default
        ) where TDependencyObject : DependencyObject, IDefaultBindProperty
        => target.BindWithString(
            Helpers.BindingExpressionToPath(pathExpressionString),
            mode,
            new FuncConverter<TSource, TPropertyValue, TParam>(convert, convertBack),
            converterParameter,
            converterLanguage,
            updateSourceTrigger,
            source,
            targetNullValue
        );

        /// <summary>Bind to the <typeparamref name="TDependencyObject"/>'s default Command and CommandParameter properties </summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        /// <param name="parameterPathExpression">If omitted, the CommandParameter property is bound to the binding context. Supports the same syntax as <paramref name="pathExpression"/></param>
        public static TDependencyObject BindCommand<TDependencyObject>(
            this TDependencyObject target,
            object pathExpression = null,
            object source = null,
            object parameterPathExpression = null,
            object parameterSource = null,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default,
            [CallerArgumentExpression("parameterPathExpression")] string parameterPathExpressionString = default
        ) where TDependencyObject : DependencyObject, IDefaultBindCommandProperties
        => target.BindCommandWithString(
            Helpers.BindingExpressionToPath(pathExpressionString),
            source,
            Helpers.BindingExpressionToPath(parameterPathExpressionString),
            parameterSource
        );

        /// <param name="parameterPath">If omitted, the CommandParameter property is bound to the binding context</param>
        /// <remarks>This overload allows to pass strings to <paramref name="path"/> and <paramref name="parameterPath"/> instead of path expressions. A path expression only uses the part after the last '.', while <paramref name="path"/> and <paramref name="parameterPath"/> allow to specify paths that contain '.'</remarks>
        public static TDependencyObject BindCommandWithString<TDependencyObject>(
            this TDependencyObject target,
            string path = bindingContextPath,
            object source = null,
            string parameterPath = bindingContextPath,
            object parameterSource = null
        ) where TDependencyObject : DependencyObject, IDefaultBindCommandProperties
        {
            Xaml.Data.BindingOperations.SetBinding(
                target.UI,
                target.DefaultBindCommandProperty,
                new Microsoft.UI.Xaml.Data.Binding
                {
                    Path = new Xaml.PropertyPath(path),
                    Mode = BindingMode.OneWay,
                    Source = source
                    // TODO: RelativeSource
                }
            );

            if (parameterPath != null)
            {
                if (target.DefaultBindCommandParameterProperty == null)
                    throw new ArgumentException($"{typeof(TDependencyObject).Name} does not have a default CommandParameterProperty", nameof(parameterPath));

                Xaml.Data.BindingOperations.SetBinding(
                    target.UI,
                    target.DefaultBindCommandParameterProperty,
                    new Microsoft.UI.Xaml.Data.Binding
                    {
                        Path = new Xaml.PropertyPath(parameterPath),
                        Mode = BindingMode.OneWay,
                        Source = parameterSource
                        // TODO: RelativeSource
                    }
                );
            }

            return target;
        }

        public static TDependencyObject Assign<TDependencyObject, TUI>(this TDependencyObject bindable, out TUI ui)
            where TDependencyObject : DependencyObject, IUI<TUI>
            where TUI : Xaml.DependencyObject
        {
            ui = (TUI)bindable.UI;
            return bindable;
        }
    }

    public static partial class DependencyObjectExtensions
    {
#if WINUI
        internal static Xaml.DependencyObject TemplatedParent { get; set; } // Part of alternative solution (see below comments)

        /// <summary>Bind the value <paramref name="property"/> in a template to the value of the property named <paramref name="sourcePropertyNameExpression"/> on a templated control</summary>
        /// <param name="sourcePropertyNameExpression">control.Property or (SomeExpression).Property <br />?. can be used safely - control instance is not required</param>
        public static TDependencyObject BindTemplate<TDependencyObject, TPropertyValue>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            object sourcePropertyNameExpression = null,
            IValueConverter converter = null,
            object converterParameter = null,
            [CallerArgumentExpression("sourcePropertyNameExpression")] string sourcePropertyNameExpressionString = default
        ) where TDependencyObject : DependencyObject
        => BindTemplate(property, Helpers.BindingExpressionToPath(sourcePropertyNameExpressionString), converter, converterParameter);

        /// <summary>Bind the value <paramref name="property"/> in a template to the value of the property named <paramref name="sourcePropertyName"/> on a templated control</summary>
        public static TDependencyObject BindTemplate<TDependencyObject, TPropertyValue>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            string sourcePropertyName,
            IValueConverter converter = null,
            object converterParameter = null
        ) where TDependencyObject : DependencyObject
        {
            property.SetBinding(new Xaml.Data.Binding
            {
                Path = new Xaml.PropertyPath(sourcePropertyName),
                Converter = converter,
                ConverterParameter = converterParameter,

                Source = TemplatedParent // Part of alternative solution
                // Note that setting Source here is a workaround for TemplatedParent not being settable for template elements created in code.
                // This workaround requires that the template is instantiated each time it is applied.
                // Alternative to eliminate this performance hit: use FrameworkElement.RegisterName and change binding to use ElementName.
                // TODO: Try to get ElementName approach to work in WinUI; named bindings in templates do not work in every context, although this may be framework specific (see e.g. https://stackoverflow.com/questions/18389118/how-does-binding-elementname-work-exactly)
            });
            return property.Target;
        }
#else
        /// <summary>Bind the value <paramref name="property"/> in a template to the value of the property named <paramref name="sourcePropertyNameExpression"/> on a templated control</summary>
        /// <param name="sourcePropertyNameExpression">control.Property or (SomeExpression).Property <br />?. can be used safely - control instance is not required</param>
        public static TDependencyObject BindTemplate<TDependencyObject, TPropertyValue>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            object sourcePropertyNameExpression = null,
            IValueConverter converter = null,
            object converterParameter = null,
            [CallerArgumentExpression("sourcePropertyNameExpression")] string sourcePropertyNameExpressionString = default
        ) where TDependencyObject : DependencyObject
        => BindTemplate(property, Helpers.BindingExpressionToPath(sourcePropertyNameExpressionString), converter, converterParameter);

        /// <summary>Bind the value <paramref name="property"/> in a template to the value of the property named <paramref name="sourcePropertyName"/> on a templated control</summary>
        public static TDependencyObject BindTemplate<TDependencyObject, TPropertyValue>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            string sourcePropertyName,
            IValueConverter converter = null,
            object converterParameter = null
        ) where TDependencyObject : DependencyObject
        {
            property.SetBinding(new Xaml.Data.Binding
            {
                Path = new Xaml.PropertyPath(sourcePropertyName),
                Converter = converter,
                ConverterParameter = converterParameter,
                RelativeSource = new(Xaml.Data.RelativeSourceMode.TemplatedParent)
            });
            return property.Target;
        }
#endif
    }

    public static partial class DependencyObjectExtensions
    {
        public static TDependencyObject AppResource<TDependencyObject, TPropertyValue>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            string name
        ) where TDependencyObject : DependencyObject
        {
            property.Target.UI.SetValue(property.UI, Xaml.Application.Current.Resources[name]);
            return property.Target;
        }
    }
}