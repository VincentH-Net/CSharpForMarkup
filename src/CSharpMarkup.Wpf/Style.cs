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