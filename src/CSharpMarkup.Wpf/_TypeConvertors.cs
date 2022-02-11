// TODO: 2022 add WinUI convertors manually for Windows App SDK - e.g. take st from WPF, manually inspect to select / add overloads, for string conv call https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.markup.xamlbindinghelper.convertvalue
// TODO: 2022 optimize with readonly, in etc: see https://docs.microsoft.com/en-us/dotnet/csharp/write-safe-efficient-code

namespace CSharpMarkup.Wpf.to // Manual (or extensions to generated) type convertors
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

    /// <summary>Set/convert to a <see cref="System.Windows.CornerRadius"/></summary>
    /// <remarks>Converts from:
    /// <code>2.5            // double uniformRadius</code>
    /// <code>(1, 2.5, 3, 4) // doubles (topLeft, topRight, bottomRight, bottomLeft)</code>
    /// <code>"2.5"          // string with double uniformRadius</code>
    /// <code>"1 2.5 3 4"    // string with doubles topLeft topRight bottomRight bottomLeft</code>
    /// <code>"1, 2.5, 3, 4" // string with doubles topLeft, topRight, bottomRight, bottomLeft</code>
    /// </remarks>
    readonly public partial struct CornerRadius
    {
        readonly System.Windows.CornerRadius value;

        public CornerRadius(System.Windows.CornerRadius value) => this.value = value;

        public static implicit operator System.Windows.CornerRadius(CornerRadius value) => value.value;
        public static implicit operator CornerRadius(System.Windows.CornerRadius value) => new(value);

        public static implicit operator CornerRadius(double uniformRadius) => new System.Windows.CornerRadius(uniformRadius);
        public static implicit operator CornerRadius((double topLeft, double topRight, double bottomRight, double bottomLeft) value) => new System.Windows.CornerRadius(value.topLeft, value.topRight, value.bottomRight, value.bottomLeft);
    }

    /// <summary>Set/convert to a <see cref="System.Windows.Size"/></summary>
    /// <remarks>Converts from:
    /// <code>(10, 5) // doubles (width, height)</code>
    /// <code>"10, 5" // string with doubles "width, height"</code>
    /// </remarks>
    readonly public partial struct Size
    {
        readonly System.Windows.Size value;

        public Size(System.Windows.Size value) => this.value = value;

        public static implicit operator System.Windows.Size(Size value) => value.value;
        public static implicit operator Size(System.Windows.Size value) => new(value);

        public static implicit operator Size((double width, double height) value) => new System.Windows.Size(value.width, value.height);
    }

    /// <summary>Set/convert to a <see cref="System.Windows.Point"/></summary>
    /// <remarks>Converts from:
    /// <code>(1, 2) // doubles (x, y)</code>
    /// <code>"1, 2" // string with doubles "x, y"</code>
    /// </remarks>
    readonly public partial struct Point
    {
        readonly System.Windows.Point value;

        public Point(System.Windows.Point value) => this.value = value;

        public static implicit operator System.Windows.Point(Point value) => value.value;
        public static implicit operator Point(System.Windows.Point value) => new(value);

        public static implicit operator Point((double x, double y) value) => new System.Windows.Point(value.x, value.y);
    }

    /// <summary>Set/convert to a <see cref="System.Windows.Duration"/></summary>
    /// <remarks>Converts from:
    /// <code>0.5       // double seconds</code>
    /// <code>"1:02:03" // "H:M:S"</code>
    /// </remarks>
    readonly public partial struct Duration
    {
        readonly System.Windows.Duration value;

        public Duration(System.Windows.Duration value) => this.value = value;

        public static implicit operator System.Windows.Duration(Duration value) => value.value;
        public static implicit operator Duration(System.Windows.Duration value) => new(value);

        public static implicit operator Duration(double seconds) => new System.Windows.Duration(System.TimeSpan.FromSeconds(seconds));

        public static System.Windows.Duration Automatic => System.Windows.Duration.Automatic;
        public static System.Windows.Duration Forever => System.Windows.Duration.Forever;
    }

    /// <summary>Set/convert to a <see cref="System.Windows.Media.Animation.KeyTime"/></summary>
    /// <remarks>Converts from:
    /// <code>0.5       // double seconds</code>
    /// <code>"25%"     // percentage</code>
    /// <code>"1:02:03" // "H:M:S"</code>
    /// </remarks>
    readonly public partial struct KeyTime
    {
        readonly System.Windows.Media.Animation.KeyTime value;

        public KeyTime(System.Windows.Media.Animation.KeyTime value) => this.value = value;

        public static implicit operator System.Windows.Media.Animation.KeyTime(KeyTime value) => value.value;
        public static implicit operator KeyTime(System.Windows.Media.Animation.KeyTime value) => new(value);

        public static implicit operator KeyTime(double seconds) => System.Windows.Media.Animation.KeyTime.FromTimeSpan(System.TimeSpan.FromSeconds(seconds));

        public static System.Windows.Media.Animation.KeyTime Paced => System.Windows.Media.Animation.KeyTime.Paced;
        public static System.Windows.Media.Animation.KeyTime Uniform => System.Windows.Media.Animation.KeyTime.Uniform;
    }
}