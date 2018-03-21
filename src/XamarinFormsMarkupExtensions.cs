using System;
using System.Collections.Generic;
using Xamarin.Forms;
#if WINDOWS_UWP
using System.Reflection;
#endif

namespace CSharpForMarkup
{
    public static class XamarinFormsMarkupExtensions
    {
        const string bindingContextPropertyName = ".";

        static Dictionary<string, BindableProperty> viewTypeDefaultProperty = new Dictionary<string, BindableProperty>
        { // Key: full type name of view, Value: the default BindableProperty
            { "Xamarin.Forms.ActivityIndicator", ActivityIndicator.IsRunningProperty },
            { "Xamarin.Forms.BoxView", BoxView.ColorProperty },
            { "Xamarin.Forms.Button", Button.CommandProperty },
            { "Xamarin.Forms.DatePicker", DatePicker.DateProperty },
            { "Xamarin.Forms.Editor", Editor.TextProperty },
            { "Xamarin.Forms.Entry", Entry.TextProperty },
            { "Xamarin.Forms.Image", Image.SourceProperty },
            { "Xamarin.Forms.Label", Label.TextProperty },
            { "Xamarin.Forms.ListView", ListView.ItemsSourceProperty },
            { "Xamarin.Forms.MasterDetailPage", Page.TitleProperty },
            { "Xamarin.Forms.MultiPage", Page.TitleProperty },
            { "Xamarin.Forms.NavigationPage", Page.TitleProperty },
            { "Xamarin.Forms.CarouselPage", Page.TitleProperty },
            { "Xamarin.Forms.ContentPage", Page.TitleProperty },
            { "Xamarin.Forms.Page", Page.TitleProperty },
            { "Xamarin.Forms.TabbedPage", Page.TitleProperty },
            { "Xamarin.Forms.TemplatedPage", Page.TitleProperty },
            { "Xamarin.Forms.Picker", Picker.SelectedIndexProperty },
            { "Xamarin.Forms.ProgressBar", ProgressBar.ProgressProperty },
            { "Xamarin.Forms.SearchBar", SearchBar.SearchCommandProperty },
            { "Xamarin.Forms.Slider", Slider.ValueProperty },
            { "Xamarin.Forms.Stepper", Stepper.ValueProperty },
            { "Xamarin.Forms.Switch", Switch.IsToggledProperty },
            { "Xamarin.Forms.TableView", TableView.BindingContextProperty },
            { "Xamarin.Forms.TimePicker", TimePicker.TimeProperty },
            { "Xamarin.Forms.WebView", WebView.SourceProperty },
            { "Xamarin.Forms.TextCell", TextCell.TextProperty },
            { "Xamarin.Forms.ToolbarItem", ToolbarItem.CommandProperty },
        };

        static BindableProperty GetDefaultProperty(Element view) // Note that we use Element type for the view variable in bind functions because we want to bind to Cell types as well as View types
        {
            BindableProperty defaultProperty;
            var viewType = view.GetType();
            string viewTypeName;

            do
            {
                viewTypeName = viewType.FullName;
                if (viewTypeDefaultProperty.TryGetValue(viewTypeName, out defaultProperty)) break;
                if (viewTypeName.StartsWith("Xamarin.Forms."))
                    throw new NotImplementedException("No default bindable property is defined for view type." + viewTypeName + "\r\nEither specify a property when calling Bind() or add a default property for this type to the viewTypeDefaultProperty dictionary.");
#if WINDOWS_UWP
                viewType = viewType.GetTypeInfo().BaseType;
#else
                viewType = viewType.BaseType;
#endif
                if (viewType == null) return null;
            } while (true);

            return defaultProperty;
        }

        public static TView Bind<TView>(this TView self, BindableProperty targetProperty, string sourcePropertyName = bindingContextPropertyName, BindingMode mode = BindingMode.Default, IValueConverter converter = null, object converterParameter = null, string stringFormat = null, object source = null) where TView : Element
        {
            if (source != null || converterParameter != null)
                self.SetBinding(targetProperty, new Binding(
                    path: sourcePropertyName,
                    mode: mode,
                    converter: converter,
                    converterParameter: converterParameter,
                    stringFormat: stringFormat,
                    source: source
                ));
            else
                self.SetBinding(targetProperty, sourcePropertyName, mode, converter, stringFormat);
            return self;
        }

        public static TView Bind<TView>(this TView self, string sourcePropertyName = bindingContextPropertyName, BindingMode mode = BindingMode.Default, IValueConverter converter = null, object converterParameter = null, string stringFormat = null, object source = null) where TView : Element
        {
            self.Bind(
                targetProperty: GetDefaultProperty(self),
                sourcePropertyName: sourcePropertyName,
                mode: mode,
                converter: converter,
                converterParameter: converterParameter,
                stringFormat: stringFormat,
                source: source
            );
            return self;
        }

        public static TView Assign<TView, TAssignView>(this TView self, out TAssignView variable) where TView : class, TAssignView
        {
            variable = self;
            return self;
        }

        public static TView Invoke<TView>(this TView self, Action<TView> action) where TView : Element
        {
            action?.Invoke(self);
            return self;
        }

        public static TView Row<TView>(this TView self, int row, int span = 1) where TView : View
        {
            self.SetValue(Grid.RowProperty, row);
            if (span != 1) self.SetValue(Grid.RowSpanProperty, span);
            return self;
        }

        public static TView RowSpan<TView>(this TView self, int span) where TView : View
        {
            self.SetValue(Grid.RowSpanProperty, span);
            return self;
        }

        public static TView Col<TView>(this TView self, int col, int span = 1) where TView : View
        {
            self.SetValue(Grid.ColumnProperty, col);
            if (span != 1) self.SetValue(Grid.ColumnSpanProperty, span);
            return self;
        }

        public static TView ColSpan<TView>(this TView self, int span) where TView : View
        {
            if (span != 1) self.SetValue(Grid.ColumnSpanProperty, span);
            return self;
        }

        public static TView RowCol<TView>(this TView self, int row, int col, int rowSpan = 1, int colSpan = 1) where TView : View
        {
            self.SetValue(Grid.RowProperty, row);
            self.SetValue(Grid.ColumnProperty, col);
            if (rowSpan != 1) self.SetValue(Grid.RowSpanProperty, rowSpan);
            if (colSpan != 1) self.SetValue(Grid.ColumnSpanProperty, colSpan);
            return self;
        }

        public static int UiSize(this int size) { return Device.RuntimePlatform == Device.WinPhone ? size + size / 2 : size; } // iOS = Android = 160 units / inch, Windows Phone = 240 units / inch
        public static double UiSize(this double size) { return Device.RuntimePlatform == Device.WinPhone ? size + size / 2 : size; } // iOS = Android = 160 units / inch, Windows Phone = 240 units / inch
    }

    public class FuncConverter : IValueConverter
    {
        private readonly Func<object> func;

        public FuncConverter(Func<object> func) { this.func = func; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (func == null) ? null : func();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class FuncConverter<TSource> : IValueConverter
    {
        private readonly Func<TSource, object> func;

        public FuncConverter(Func<TSource, object> func) { this.func = func; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (func == null) ? null : func((TSource)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ToStringConverter : FuncConverter<object> { public ToStringConverter(string format = "{0}") : base(o => string.Format(format, o)) { } }
    public class ShortTimeConverter : FuncConverter<DateTimeOffset> { public ShortTimeConverter() : base(t => t.ToString("t")) { } }
    public class BoolNotConverter : FuncConverter<bool>
    {
        private static readonly Lazy<BoolNotConverter> instance = new Lazy<BoolNotConverter>(() => new BoolNotConverter());
        public static BoolNotConverter Instance { get { return instance.Value; } }
        public BoolNotConverter() : base(t => !t) { }
    }
}
