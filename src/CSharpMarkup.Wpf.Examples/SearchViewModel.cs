using System.Diagnostics;

namespace WpfCsMarkupExamples;

public class SearchViewModel : BaseViewModel
{
    ICommand? goToOtherCommand, searchCommand, likeCommand;

    public string SearchText { get; set; } = string.Empty;

    public List<Tweet> SearchResults { get; set; }= new ();

    public ICommand GoToOtherCommand => goToOtherCommand ??= new RelayCommand(GoToOther);
    public ICommand SearchCommand => searchCommand ??= new RelayCommand(Search);
    public ICommand LikeCommand => likeCommand ??= new RelayCommand<Tweet>(Like);

    public SearchViewModel Initialize()
    {
        SearchText = "#CSharpForMarkup";

        SearchResults = new List<Tweet>
        {
            new Tweet
            {
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
            new Tweet
            {
                AuthorImage = "https://pbs.twimg.com/profile_images/2159034926/MACAW_vincenth_LThumb_400x400.jpg",
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
            new Tweet
            {
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
            new Tweet
            {
                AuthorImage = "https://pbs.twimg.com/profile_images/2159034926/MACAW_vincenth_LThumb_400x400.jpg",
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
            new Tweet
            {
                AuthorImage = "https://pbs.twimg.com/profile_images/2159034926/MACAW_vincenth_LThumb_400x400.jpg",
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
        };

        return this;
    }

    public static Uri LinkUri(string linkText) => new(linkText.StartsWith("#") == true ? TwitterSearchUri(linkText) : linkText, uriKind: UriKind.Absolute);

    void GoToOther() => App.Current?.NavigateToFlutterPage();
    void Search() => App.LaunchUri(new Uri(TwitterSearchUri(SearchText)));
    void Like(Tweet tweet) => tweet.IsLikedByMe = !tweet.IsLikedByMe;

    public static string TwitterSearchUri(string text) => $"https://twitter.com/search?q={Uri.EscapeDataString(text)}&f=live";

    public class Tweet : BaseViewModel
    {
        public string? AuthorImage { get; set; }
        public string? Header { get; set; }
        public List<TextFragment>? Body { get; set; }
        public bool IsLikedByMe { get; set; }
    }

    public class TextFragment
    {
        public string? Text { get; set; }

        public bool IsMatch { get; set; }
    }
}