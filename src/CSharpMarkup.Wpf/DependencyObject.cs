using System;
using System.Runtime.CompilerServices;
using BindingMode = System.Windows.Data.BindingMode;
using IValueConverter = System.Windows.Data.IValueConverter;
using UpdateSourceTrigger = System.Windows.Data.UpdateSourceTrigger;

namespace CSharpMarkup.Wpf
{
    public static partial class Helpers
    {
        /// <summary>Bind a <see cref="System.Windows.DependencyProperty"/> in a <see cref="CSharpMarkup.Wpf.Style"/>. Use to specify a parameter for e.g. <see cref="Style{T}((System.Windows.DependencyProperty property, UIObject value)[])"/></summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static (System.Windows.DependencyProperty, System.Windows.Data.Binding) Bind(
            this System.Windows.DependencyProperty property,
            object pathExpression = null,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            object targetNullValue = default,
            object fallbackValue = default,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default
        ) => (property, new System.Windows.Data.Binding
        {
            Path = new System.Windows.PropertyPath(BindingExpressionToPath(pathExpressionString)),
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

        /// <summary>Bind a <see cref="System.Windows.DependencyProperty"/> with inline conversion in a <see cref="CSharpMarkup.Wpf.Style"/>. Use to specify a parameter for e.g. <see cref="Style{T}((System.Windows.DependencyProperty property, UIObject value)[])"/></summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static (System.Windows.DependencyProperty, System.Windows.Data.Binding) Bind<TPropertyValue, TSource>(
            this System.Windows.DependencyProperty property,
            object pathExpression = null,
            BindingMode mode = BindingMode.Default,
            Func<TSource, TPropertyValue> convert = null,
            Func<TPropertyValue, TSource> convertBack = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            TPropertyValue targetNullValue = default,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default
        ) => (property, new System.Windows.Data.Binding
        {
            Path = new System.Windows.PropertyPath(BindingExpressionToPath(pathExpressionString)),
            Mode = mode,
            Converter = new FuncConverter<TSource, TPropertyValue, object>(convert, convertBack),
            //ConverterLanguage = converterLanguage, // TODO: figure out correct default; can't be null
            UpdateSourceTrigger = updateSourceTrigger,
            Source = source,
            // TODO: RelativeSource
            TargetNullValue = targetNullValue
        });


        /// <summary>Bind a <see cref="System.Windows.DependencyProperty"/> with inline conversion and conversion parameter in a <see cref="CSharpMarkup.Wpf.Style"/>. Use to specify a parameter for e.g. <see cref="Style{T}((System.Windows.DependencyProperty property, UIObject value)[])"/></summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static (System.Windows.DependencyProperty, System.Windows.Data.Binding) Bind<TPropertyValue, TSource, TParam>(
            this System.Windows.DependencyProperty property,
            object pathExpression = null,
            BindingMode mode = BindingMode.Default,
            Func<TSource, TParam, TPropertyValue> convert = null,
            Func<TPropertyValue, TParam, TSource> convertBack = null,
            TParam converterParameter = default,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            TPropertyValue targetNullValue = default,
            [CallerArgumentExpression("pathExpression")] string pathExpressionString = default
        ) => (property, new System.Windows.Data.Binding
        {
            Path = new System.Windows.PropertyPath(BindingExpressionToPath(pathExpressionString)),
            Mode = mode,
            Converter = new FuncConverter<TSource, TPropertyValue, TParam>(convert, convertBack),
            ConverterParameter = converterParameter,
            //ConverterLanguage = converterLanguage, // TODO: figure out correct default; can't be null
            UpdateSourceTrigger = updateSourceTrigger,
            Source = source,
            // TODO: RelativeSource
            TargetNullValue = targetNullValue
        });

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

        public static string NameExpressionToName(string? nameExpression)
        {
            if (nameExpression == null) return String.Empty;

            int startOfName = nameExpression.LastIndexOf('.') + 1;

            return nameExpression
                .Substring(startOfName)     // Ignore anything before the last '.'
                .Replace("?", "")           // Allow .xName (instance?.Name) => "Name", where instance is a null instance field used for binding only
                .Trim('"', '@', ' ', '\t'); // Allow .xName ("Name") => "Name"
        }
    }

    public interface IUI<TUI> where TUI : System.Windows.DependencyObject
    {
        TUI UI { get; }
    }

    public interface IUI_Dispatcher<TUI> where TUI : System.Windows.Threading.DispatcherObject
    {
        TUI UI { get; }
    }

    /// <summary>
    /// Allows to specify <see cref="CSharpMarkup.Wpf"/> types (e.g. <see cref="TextBlock"/>) as well as commonly used built-in C# / UI types (e.g. <see cref="string"/> or <see cref="System.Windows.Thickness"/>).
    /// </summary>
    /// <remarks>For types not supported by implicit conversion, use the <see cref="UIObject(object)"/> contructor, e.g.: <code>new (FontCapitals.Normal)</code></remarks>
    public class UIObject
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
        public static implicit operator UIObject(System.Windows.CornerRadius value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.Duration value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.FigureLength value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.FontStretch value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.FontStyle value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.FontWeight value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.GridLength value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.Int32Rect value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.Point value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.Rect value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.Size value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.Thickness value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.Media.Color value) => new UIObject(value);

        // Enum types
        public static implicit operator UIObject(System.Windows.BaselineAlignment value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.FigureHorizontalAnchor value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.FigureVerticalAnchor value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.FlowDirection value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.HorizontalAlignment value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.LineBreakCondition value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.LineStackingStrategy value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.TextAlignment value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.TextDecorationLocation value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.TextTrimming value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.TextWrapping value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.VerticalAlignment value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.Visibility value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.WrapDirection value) => new UIObject(value);

        // Non-markup class types
        public static implicit operator UIObject(System.Windows.Media.FontFamily value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.ResourceKey value) => new UIObject(value);
        public static implicit operator UIObject(System.Windows.Data.Binding value) => new UIObject(value);

        // Markup types
        public static implicit operator UIObject(DispatcherObject value) => new UIObject(value.UI);

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
            BindingMode mode = BindingMode.Default,
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
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            TPropertyValue targetNullValue = default,
            TPropertyValue fallbackValue = default
        ) where TDependencyObject : DependencyObject
        => property.SetBinding(new System.Windows.Data.Binding
        {
            Path = new System.Windows.PropertyPath(path),
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
            BindingMode mode = BindingMode.Default,
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
            BindingMode mode = BindingMode.Default,
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
            BindingMode mode = BindingMode.Default,
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
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string converterLanguage = null,
            UpdateSourceTrigger updateSourceTrigger = UpdateSourceTrigger.Default,
            object source = null,
            object targetNullValue = default,
            object fallbackValue = default
        ) where TDependencyObject : DependencyObject, IDefaultBindProperty
        {
            var binding = new System.Windows.Data.Binding(path)
            {
                Mode = mode,
                Converter = converter,
                ConverterParameter = converterParameter,
                //ConverterLanguage = converterLanguage, // TODO: figure out correct default; can't be null
                UpdateSourceTrigger = updateSourceTrigger,
                // TODO: RelativeSource
                TargetNullValue = targetNullValue,
                FallbackValue = fallbackValue,
            };
            if (source != null) binding.Source = source; // In WPF, setting the binding Source to null prevents the binding from working, even though the value of Source in the created binding is null

            System.Windows.Data.BindingOperations.SetBinding(
                target.UI,
                target.DefaultBindProperty,
                binding
            );
            return target;
        }

        /// <summary>Bind to the default property with inline conversion</summary>
        /// <param name="pathExpression">viewModel.Property or viewModel.Property1.Property2 or (SomeExpression.viewModel).Property <br />?. can be used safely - viewmodel instance is not required</param>
        public static TDependencyObject Bind<TDependencyObject, TPropertyValue, TSource>(
            this TDependencyObject target,
            object pathExpression = null,
            BindingMode mode = BindingMode.Default,
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
            BindingMode mode = BindingMode.Default,
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
            var binding = new System.Windows.Data.Binding(path)
            {
                Mode = BindingMode.Default,
                // TODO: RelativeSource
            };

            if (source != null) binding.Source = source; // In WPF, setting the binding Source to null prevents the binding from working, even though the value of Source in the created binding is null

            System.Windows.Data.BindingOperations.SetBinding(
                target.UI,
                target.DefaultBindCommandProperty,
                binding
            );

            if (parameterPath != null)
            {
                if (target.DefaultBindCommandParameterProperty == null)
                    throw new ArgumentException($"{typeof(TDependencyObject).Name} does not have a default CommandParameterProperty", nameof(parameterPath));

                binding = new System.Windows.Data.Binding(parameterPath)
                {
                    Mode = BindingMode.Default
                    // TODO: RelativeSource
                };

                if (parameterSource != null) binding.Source = parameterSource; // In WPF, setting the binding Source to null prevents the binding from working, even though the value of Source in the created binding is null

                System.Windows.Data.BindingOperations.SetBinding(
                    target.UI,
                    target.DefaultBindCommandParameterProperty,
                    binding
                );
            }

            return target;
        }

        public static TDependencyObject Assign<TDependencyObject, TUI>(this TDependencyObject bindable, out TUI ui)
            where TDependencyObject : DependencyObject, IUI<TUI>
            where TUI : System.Windows.DependencyObject
        {
            ui = (TUI)bindable.UI;
            return bindable;
        }
    }

    public static partial class DependencyObjectExtensions
    {
        internal static System.Windows.DependencyObject TemplatedParent { get; set; } // Part of alternative solution (see below comments)

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

        /// <summary>Bind the value <paramref name="property"/> in a template to the value of the <paramref name="sourceProperty"/> on a templated control</summary>
        public static TDependencyObject BindTemplate<TDependencyObject, TPropertyValue>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            System.Windows.DependencyProperty sourceProperty,
            IValueConverter converter = null,
            object converterParameter = null
        ) where TDependencyObject : DependencyObject
        => BindTemplate(property, sourceProperty.Name, converter, converterParameter);

        /// <summary>Bind the value <paramref name="property"/> in a template to the value of the property named <paramref name="sourcePropertyName"/> on a templated control</summary>
        public static TDependencyObject BindTemplate<TDependencyObject, TPropertyValue>(
            this DependencyProperty<TDependencyObject, TPropertyValue> property,
            string sourcePropertyName,
            IValueConverter converter = null,
            object converterParameter = null
        ) where TDependencyObject : DependencyObject
        {
            property.SetBinding(new System.Windows.Data.Binding
            {
                Path = new System.Windows.PropertyPath(sourcePropertyName),
                Converter = converter,
                ConverterParameter = converterParameter,

                // Part of XamlWrite solution: RelativeSource = new(System.Windows.Data.RelativeSourceMode.TemplatedParent)
                Source = TemplatedParent // Part of alternative solution
                // Note that setting Source here is a workaround for TemplatedParent not being settable for template elements created in code.
                // This workaround requires that the template is instantiated each time it is applied.
                // Alternatives to eliminate this performance hit are:
                // 1) Use FrameworkElement.RegisterName and change binding to use ElementName.
                //    However this does not seem to work - and also named bindings in templates do not work in every context, although this may be framework specific (see e.g. https://stackoverflow.com/questions/18389118/how-does-binding-elementname-work-exactly)
                // 2) Use XamlWriter and XamlReader to serialize and deserialize the template once
                //    This does require to register a type convertor to serialize binding expressions, e.g. see https://www.codeproject.com/Articles/27158/XamlWriter-and-Bindings-Serialization
                //    This works in WPF to set the TemplatedParent.
                //    With the limitation that XamlWriter does not serialize VisualStates: https://social.msdn.microsoft.com/Forums/vstudio/en-US/e1103342-86b1-4a39-8f85-078de20f5551/xamlwritersave-is-not-serializing-the-visual-state-manager-nodes?forum=wpf
                //    However WinUI 3 does not have (or plan to have) a XamlWriter
                //    In addition, WinUI3 Desktop does not have TemplatedParent read access - the property does not exist in WinUI3 FrameworkElement
                //    Uno Platform WinUI3 does not need a workaround, it exposes all FrameworkTemplate derives classes to C#
            });
            return property.Target;
        }
    }
}