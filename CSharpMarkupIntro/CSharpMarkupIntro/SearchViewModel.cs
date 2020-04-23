using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace CSharpMarkupIntro
{
    public class SearchViewModel : BaseViewModel
    {
        ICommand backCommand, cancelCommand, likeCommand;

        public string SearchText { get; set; }

        public List<Tweet> SearchResults { get; set; }

        public void Initialize()
        {
            SearchText = "#CSharpForMarkup";

            SearchResults = new List<Tweet>
            {
                new Tweet
                {
                    AuthorImage = "https://pbs.twimg.com/profile_images/1174080109399224322/Yc0k4Bqe_400x400.jpg",
                    Header = "David Ortinau @davidortinau · 25/10/2020",
                    Body = new List<TextFragment>
                    {
                        new TextFragment { Text = "would it surprise you to know that the last project I personally shipped was Xamarin.Forms, C# w/ " },
                        new TextFragment { Text = "#CSharpForMarkup", IsMatch = true },
                        new TextFragment { Text = ", & @ReactiveXUI?" }
                    },
                },
                new Tweet
                {
                    AuthorImage = "https://pbs.twimg.com/profile_images/2159034926/MACAW_vincenth_LThumb_400x400.jpg",
                    Header = "VincentH.NET @vincenth_net · 26/03/2020",
                    Body = new List<TextFragment>
                    {
                        new TextFragment { Text = "Had an inspiring call with @matthewrdev about supporting #XamarinForms C# Markup in @mfractor\uD83D\uDE0E\n\nSo many great ideas. Autoformat, Convert XAML to C# Markup (all examples on internet!), auto split UI logic and markup...\n\nExcited " },
                        new TextFragment { Text = "#CSharpForMarkup", IsMatch = true },
                        new TextFragment { Text = "\uD83D\uDD25" }
                    },
                },
                new Tweet
                {
                    AuthorImage = "https://pbs.twimg.com/profile_images/1175428143944847361/0kfeW53l_400x400.jpg",
                    Header = "RK @rkonit · 05/02/2020",
                    Body = new List<TextFragment>
                    {
                        new TextFragment { Text = "\"Never Say Never\" in Open-source space. It's happening and reminds me early days of winforms.\n\n" },
                        new TextFragment { Text = "#CSharpForMarkup", IsMatch = true },
                        new TextFragment { Text = " #Xamarin #XamarinForms" }
                    },
                }
            };
        }

        public ICommand BackCommand => backCommand ??= new RelayCommand(Back);
        public ICommand CancelCommand => cancelCommand ??= new RelayCommand(Cancel);
        public ICommand LikeCommand => likeCommand ??= new RelayCommand<Tweet>(Like);

        void Back() { }
        
        
        void Cancel() { }
        
        void Like(Tweet tweet) 
        {
            tweet.IsLikedByMe = !tweet.IsLikedByMe;
        }

        public class Tweet : BaseViewModel
        {
            public string AuthorImage { get; set; }
            public string Header { get; set; }
            public List<TextFragment> Body { get; set; }
            public bool IsLikedByMe { get; set; }
        }

        public class TextFragment
        {
            public string Text { get; set; }

            public bool IsMatch { get; set; }
        }
    }
}
