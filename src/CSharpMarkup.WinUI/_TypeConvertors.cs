namespace CSharpMarkup.WinUI.to
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

    /// <summary>Set/convert to a <see cref="Windows.Foundation.Size"/></summary>
    /// <remarks>Converts from:
    /// <code>(10, 5) // doubles (width, height)</code>
    /// </remarks>
    readonly public partial struct Size
    {
        readonly Windows.Foundation.Size value;

        public Size(Windows.Foundation.Size value) => this.value = value;

        public static implicit operator Windows.Foundation.Size(Size value) => value.value;
        public static implicit operator Size(Windows.Foundation.Size value) => new(value);

        public static implicit operator Size((double width, double height) value) => new Windows.Foundation.Size(value.width, value.height);
    }

    /// <summary>Set/convert to a <see cref="Windows.Foundation.Point"/></summary>
    /// <remarks>Converts from:
    /// <code>(1, 2) // doubles (x, y)</code>
    /// </remarks>
    readonly public partial struct Point
    {
        readonly Windows.Foundation.Point value;

        public Point(Windows.Foundation.Point value) => this.value = value;

        public static implicit operator Windows.Foundation.Point(Point value) => value.value;
        public static implicit operator Point(Windows.Foundation.Point value) => new(value);

        public static implicit operator Point((double x, double y) value) => new Windows.Foundation.Point(value.x, value.y);
    }

    /// <summary>Set/convert to a <see cref="Microsoft.UI.Xaml.Duration"/></summary>
    /// <remarks>Converts from:
    /// <code>0.5       // double seconds</code>
    /// </remarks>
    readonly public partial struct Duration
    {
        readonly Microsoft.UI.Xaml.Duration value;

        public Duration(Microsoft.UI.Xaml.Duration value) => this.value = value;

        public static implicit operator Microsoft.UI.Xaml.Duration(Duration value) => value.value;
        public static implicit operator Duration(Microsoft.UI.Xaml.Duration value) => new(value);

        public static implicit operator Duration(double seconds) => new Microsoft.UI.Xaml.Duration(System.TimeSpan.FromSeconds(seconds));

        public static Microsoft.UI.Xaml.Duration Automatic => Microsoft.UI.Xaml.Duration.Automatic;
        public static Microsoft.UI.Xaml.Duration Forever => Microsoft.UI.Xaml.Duration.Forever;
    }

    /// <summary>Set/convert to a <see cref="Microsoft.UI.Xaml.Media.Animation.KeyTime"/></summary>
    /// <remarks>Converts from:
    /// <code>0.5       // double seconds</code>
    /// </remarks>
    readonly public partial struct KeyTime
    {
        readonly Microsoft.UI.Xaml.Media.Animation.KeyTime value;

        public KeyTime(Microsoft.UI.Xaml.Media.Animation.KeyTime value) => this.value = value;

        public static implicit operator Microsoft.UI.Xaml.Media.Animation.KeyTime(KeyTime value) => value.value;
        public static implicit operator KeyTime(Microsoft.UI.Xaml.Media.Animation.KeyTime value) => new(value);

        public static implicit operator KeyTime(double seconds) => Microsoft.UI.Xaml.Media.Animation.KeyTime.FromTimeSpan(System.TimeSpan.FromSeconds(seconds));
    }
}
