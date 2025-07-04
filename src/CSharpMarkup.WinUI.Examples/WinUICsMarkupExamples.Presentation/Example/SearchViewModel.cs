namespace WinUICsMarkupExamples.Presentation.Example;

[UIBindable]
public sealed partial class SearchViewModel(INavigator navigator) : BaseViewModel
{
    [ObservableProperty] public partial string SearchText { get; set; } = "#CSharpForMarkup";

    [ObservableProperty] public partial List<Tweet> SearchResults { get; set; } = [
        new() {
            AuthorImage = "https://pbs.twimg.com/profile_images/1382769074569154561/2ukpzO8E_400x400.jpg",
            Header = "Uno Platform @UnoPlatform · Nov 30",
            Body = new List<TextFragment>
            {
                new TextFragment { Text = "Premiered today at " },
                new TextFragment { Text = "#UnoConf", IsMatch = true },
                new TextFragment { Text = ":\n\n\U0001F4E2 C# Markup 2 for " },
                new TextFragment { Text = "#WinUI3", IsMatch = true },
                new TextFragment { Text = " and Uno Platform\n\n" },

                new TextFragment { Text = "Check out the preview:\n" },
                new TextFragment { Text = "https://github.com/VincentH-Net/CSharpForMarkup", IsMatch = true },
                new TextFragment { Text = "\n" },

                new TextFragment { Text = "#CSharpForMarkup", IsMatch = true },
                new TextFragment { Text = " " },
                new TextFragment { Text = "#webassembly", IsMatch = true },
                new TextFragment { Text = " " },
                new TextFragment { Text = "#dotnet", IsMatch = true },
            },
            IsLikedByMe = true
        },
        new() {
            AuthorImage = "https://pbs.twimg.com/profile_images/1527601353312419841/V7FQ6ftO_400x400.jpg",
            Header = "VincentH.NET @vincenth_net · Nov 30",
            Body = new List<TextFragment>
            {
                new TextFragment { Text = "Released the first preview of\n\U0001F4E2 C# Markup 2 for " },
                new TextFragment { Text = "#WinUI3", IsMatch = true },
                new TextFragment { Text = " and Uno Platform!\U0001F60E\n" },
                new TextFragment { Text = "https://github.com/VincentH-Net/CSharpForMarkup", IsMatch = true },
                new TextFragment { Text = "\n\nSee it in action in " },
                new TextFragment { Text = "#UnoConf", IsMatch = true },
                new TextFragment { Text = " today\n" },
                new TextFragment { Text = "#CSharpForMarkup", IsMatch = true }
            },
        },
        new() {
            AuthorImage = "https://pbs.twimg.com/profile_images/1382769074569154561/2ukpzO8E_400x400.jpg",
            Header = "Uno Platform @UnoPlatform · Nov 30",
            Body = new List<TextFragment>
            {
                new TextFragment { Text = "Shown at " },
                new TextFragment { Text = "#UnoConf", IsMatch = true },
                new TextFragment { Text = " today: create browser " },
                new TextFragment { Text = "#webassembly", IsMatch = true  },
                new TextFragment { Text = " apps and native crossplatform apps completely in C# 10, .NET 6 and " },
                new TextFragment { Text = "#WinUI3", IsMatch = true },
                new TextFragment { Text = ". No XAML or HTML required. Check out the preview:\n\n" },

                new TextFragment { Text = "C# Markup 2 for " },
                new TextFragment { Text = "#WinUI3", IsMatch = true },
                new TextFragment { Text = " and Uno Platform\n" },
                new TextFragment { Text = "https://github.com/VincentH-Net/CSharpForMarkup", IsMatch = true },
            },
            IsLikedByMe = true
        },
        new() {
            AuthorImage = "https://pbs.twimg.com/profile_images/1527601353312419841/V7FQ6ftO_400x400.jpg",
            Header = "VincentH.NET @vincenth_net · Nov 30",
            Body = new List<TextFragment>
            {
                new TextFragment { Text = "\U0001F60E Interested in a " },
                new TextFragment { Text = "#Flutter", IsMatch = true },
                new TextFragment { Text = " like development experience for @UnoPlatform? Check out C# Markup 2 for " },
                new TextFragment { Text = "#WinUI3", IsMatch = true },
                new TextFragment { Text = " and Uno Platform. Works with " },
                new TextFragment { Text = "#dotnet", IsMatch = true },
                new TextFragment { Text = " " },
                new TextFragment { Text = "#hotreload", IsMatch = true  },
                new TextFragment { Text = "\U0001F525 in " },
                new TextFragment { Text = "#VS2022", IsMatch = true },
                new TextFragment { Text = "\n\n" },
                new TextFragment { Text = "https://github.com/VincentH-Net/CSharpForMarkup", IsMatch = true },
                new TextFragment { Text = "\n" },
                new TextFragment { Text = "#CSharpForMarkup", IsMatch = true },
            },
        },
        new() {
            AuthorImage = "https://pbs.twimg.com/profile_images/1527601353312419841/V7FQ6ftO_400x400.jpg",
            Header = "VincentH.NET @vincenth_net · Nov 15",
            Body = new List<TextFragment>
            {
                new TextFragment { Text = "I have " },
                new TextFragment { Text = "#CSharpForMarkup", IsMatch = true },
                new TextFragment { Text = " gen 2 working in " },
                new TextFragment { Text = "#WinUI3", IsMatch = true },
                new TextFragment { Text = " on " },
                new TextFragment { Text = "#dotnet6", IsMatch = true },
                new TextFragment { Text = " with " },
                new TextFragment { Text = "#hotreload", IsMatch = true },
                new TextFragment { Text = " in " },
                new TextFragment { Text = "#VS2022", IsMatch = true },

                new TextFragment { Text = "\n\nNow I can use the " },
                new TextFragment { Text = "#csharp10", IsMatch = true },
                new TextFragment { Text = " CallerArgumentExpression attribute to eliminate nameof() in bindings\n\n" },

                new TextFragment { Text = "Working towards a preview release. More soon!" }
            },
            IsLikedByMe = true
        }
    ];

    public static Uri LinkUri(string linkText) => new(linkText.StartsWith("#", StringComparison.Ordinal) ? TwitterSearchUri(linkText) : linkText);

    [RelayCommand] public async Task Forward() => await navigator.NavigateViewModelAsync<ScottPlotViewModel>(this);
    [RelayCommand] public async Task Search() => await LaunchUri(TwitterSearchUri(SearchText));
    [RelayCommand] public static void Like(Tweet tweet) => tweet.IsLikedByMe = !tweet.IsLikedByMe;

    static string TwitterSearchUri(string text) => $"https://twitter.com/search?q={Uri.EscapeDataString(text)}&f=live";
    static async Task LaunchUri(string uriString) => await Windows.System.Launcher.LaunchUriAsync(new Uri(uriString));

    public sealed partial class Tweet : BaseViewModel
    {
        [ObservableProperty] public partial string? AuthorImage { get; set; }
        [ObservableProperty] public partial string? Header { get; set; }
        [ObservableProperty] public partial List<TextFragment>? Body { get; set; }
        [ObservableProperty] public partial bool IsLikedByMe { get; set; }
    }

    public sealed class TextFragment
    {
        public string Text { get; set; } = string.Empty;

        public bool IsMatch { get; set; }
    }
}
