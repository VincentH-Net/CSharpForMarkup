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

                    Header = "A Header",

                    Body = new List<TextFragment>
                    {
                        new TextFragment { Text = "Some " },
                        new TextFragment { Text = "#CSharpForMarkup", IsMatch = true },
                        new TextFragment { Text = " body" },
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
