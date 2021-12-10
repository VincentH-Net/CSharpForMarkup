using System;
using System.Reflection;
using Windows = System.Windows;

namespace CSharpMarkup.Wpf
{
	public static partial class Helpers
	{
		// TODO: ? how to let intellisense offer only styles for the type?
		// will helper .Style<T>(this T, Style<T> style) interfere with the generated .Style(this T, Style style)?
	}

	public static partial class FrameworkElementExtensions
	{
		/// <summary>Set <see cref="Windows.FrameworkElement.Style"/> to a type-safe <see cref='Style<typeparamref name="TView"/>'/></summary>
		public static TView Style<TView>(this TView view, Style<TView> style) where TView : FrameworkElement { view.UI.Style = style; return view; }
	}

	public class Style<T> : Style where T : DependencyObject
	{
		void Initialize() => UI = new Windows.Style(typeof(T).GetProperty("UI", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).PropertyType);

		public Style() => Initialize();

		public Style(Windows.DependencyProperty property, object value) { Initialize(); Set(property, value); }

		public Style(params (Windows.DependencyProperty property, object value)[] setters) { Initialize(); Set(setters); }

		public Style<T> Set(Windows.DependencyProperty property, object value) => Set((property, value));

		public Style<T> Set(params (Windows.DependencyProperty property, object value)[] setters)
		{
			foreach (var setter in setters)
				UI.Setters.Add(new Windows.Setter(setter.property, setter.value));
			return this;
		}
	}
}

// Below is from generated code when DispatcherObject is used as the view base type
// Only manual change is IUI to IUI_Dispatcher
namespace CSharpMarkup.Wpf // Style
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style(O<Windows.Style> BasedOn = default, O<Windows.ResourceDictionary> Resources = default, O<Type> TargetType = default)
        {
            var ui = new Windows.Style();
            if (BasedOn.HasValue) ui.BasedOn = BasedOn.Value;
            if (Resources.HasValue) ui.Resources = Resources.Value;
            if (TargetType.HasValue) ui.TargetType = TargetType.Value;
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style()
        {
            var ui = new Windows.Style();
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style(Type targetType)
        {
            var ui = new Windows.Style(targetType);
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style(Type targetType, Windows.Style basedOn)
        {
            var ui = new Windows.Style(targetType, basedOn);
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }
    }

    public partial class Style : DispatcherObject, IUI_Dispatcher<System.Windows.Style>
    {
        static Style instance;

        internal static Style StartChain(Windows.Style ui)
        {
            if (instance == null) instance = new Style();
            instance.UI = ui;
            return instance;
        }

        Windows.Style ui;

        public new Windows.Style UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Style(Style view) => view?.UI;

        public static implicit operator Style(Windows.Style ui) => Style.StartChain(ui);

        protected Style() { }
    }

    public static partial class StyleExtensions
    {
        /// <summary>Set <see cref="Windows.Style.BasedOn"/></summary>
        public static TView BasedOn<TView>(this TView view, Windows.Style value) where TView : Style { view.UI.BasedOn = value; return view; }

        /// <summary>Set <see cref="Windows.Style.Resources"/></summary>
        public static TView Resources<TView>(this TView view, Windows.ResourceDictionary value) where TView : Style { view.UI.Resources = value; return view; }

        /// <summary>Set <see cref="Windows.Style.TargetType"/></summary>
        public static TView TargetType<TView>(this TView view, Type value) where TView : Style { view.UI.TargetType = value; return view; }
    }
}
