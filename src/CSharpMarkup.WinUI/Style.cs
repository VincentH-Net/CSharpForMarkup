using System.Reflection;
using Xaml = Microsoft.UI.Xaml;

namespace CSharpMarkup.WinUI
{
	public static partial class Helpers
	{
		// TODO: ? how to let intellisense offer only styles for the type?
		// will helper .Style<T>(this T, Style<T> style) interfere with the generated .Style(this T, Style style)?
	}

	public static partial class FrameworkElementExtensions
	{
		/// <summary>Set <see cref="Xaml.FrameworkElement.Style"/> to a type-safe <see cref='Style<typeparamref name="TView"/>'/></summary>
		public static TView Style<TView>(this TView view, Style<TView> style) where TView : FrameworkElement { view.UI.Style = style; return view; }
	}

	public class Style<T> : Style where T : DependencyObject
	{
		void Initialize() => UI = new Xaml.Style(typeof(T).GetProperty("UI", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).PropertyType);

		public Style() => Initialize();

		public Style(Xaml.DependencyProperty property, UIObject value) { Initialize(); Set(property, value); }

		public Style(params (Xaml.DependencyProperty property, UIObject value)[] setters) { Initialize(); Set(setters); }

		public Style<T> Set(Xaml.DependencyProperty property, UIObject value) => Set((property, value));

		public Style<T> Set(params (Xaml.DependencyProperty property, UIObject value)[] setters)
		{
			foreach ((var property, var value) in setters)
				UI.Setters.Add(new Xaml.Setter(property, value.UI));
			return this;
		}
	}
}