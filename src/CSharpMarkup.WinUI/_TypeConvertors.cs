// TODO: 2022 add WinUI convertors manually for Windows App SDK - e.g. take st from WPF, manually inspect to select / add overloads, for string conv call https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.markup.xamlbindinghelper.convertvalue
// TODO: 2022 optimize with readonly, in etc: see https://docs.microsoft.com/en-us/dotnet/csharp/write-safe-efficient-code

namespace CSharpMarkup.WinUI.to // Manual (or extensions to generated) type convertors
{
    /// <summary>Set/convert to a <see cref="System.TimeSpan"/></summary>
    /// <remarks>Converts from:
    /// <code>0.5       // double seconds</code>
    /// <code>"1:02:03" // "H:M:S"</code>
    /// </remarks>
    readonly public partial struct TimeSpan
    {
        readonly System.TimeSpan value;
        public TimeSpan(System.TimeSpan timeSpan) => value = timeSpan;

        public static implicit operator System.TimeSpan(TimeSpan timeSpan) => timeSpan.value;
        public static implicit operator TimeSpan(System.TimeSpan timeSpan) => new(timeSpan);

        public static implicit operator TimeSpan(string timeSpan) => System.TimeSpan.Parse(timeSpan);
        public static implicit operator TimeSpan(double seconds) => System.TimeSpan.FromSeconds(seconds);
    }

    /// <summary>Set/convert to a <see cref="Microsoft.UI.Xaml.CornerRadius"/></summary>
    /// <remarks>Converts from:
    /// <code>2.5            // double uniformRadius</code>
    /// <code>(1, 2.5, 3, 4) // doubles (topLeft, topRight, bottomRight, bottomLeft)</code>
    /// <code>"2.5"          // string with double uniformRadius</code>
    /// <code>"1 2.5 3 4"    // string with doubles topLeft topRight bottomRight bottomLeft</code>
    /// <code>"1, 2.5, 3, 4" // string with doubles topLeft, topRight, bottomRight, bottomLeft</code>
    /// </remarks>
    readonly public partial struct CornerRadius
    {
        readonly Microsoft.UI.Xaml.CornerRadius value;

        public CornerRadius(Microsoft.UI.Xaml.CornerRadius value) => this.value = value;

        public static implicit operator Microsoft.UI.Xaml.CornerRadius(CornerRadius value) => value.value;
        public static implicit operator CornerRadius(Microsoft.UI.Xaml.CornerRadius value) => new(value);

        public static implicit operator CornerRadius(double uniformRadius) => new Microsoft.UI.Xaml.CornerRadius(uniformRadius);
        public static implicit operator CornerRadius((double topLeft, double topRight, double bottomRight, double bottomLeft) value) => new Microsoft.UI.Xaml.CornerRadius(value.topLeft, value.topRight, value.bottomRight, value.bottomLeft);
    }
}
