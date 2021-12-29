#if DEBUG
using Microsoft.UI.Xaml.Controls;
using static Microsoft.UI.Colors;
using Color = Windows.UI.Color;
using Markup = CSharpMarkup.WinUI;
using UI = Microsoft.UI.Xaml;

namespace CompileTests
{
    partial class TestPage : Page
    {
        TestViewModel vm = new();

        Button button;
        readonly Markup.FuncConverter<bool, UI.Media.Brush> okBrushConverter;

        public TestPage()
        {
            okBrushConverter = new (OkBrush);
            // Set viewmodel and set content to markup here
        }

        UI.Media.Brush OkBrush(bool isOk) => new UI.Media.SolidColorBrush(OkColor(isOk));

        Color OkColor(bool isOk) => isOk ? Green : Red;
    }
}
#endif