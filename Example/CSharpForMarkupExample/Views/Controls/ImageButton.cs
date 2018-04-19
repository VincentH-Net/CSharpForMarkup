using QuickCross;
using System.Windows.Input;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace CSharpForMarkupExample.Views.Controls
{
    class ImageButton : Image
    {
        public static readonly BindableProperty CurrentStateSourceProperty =
            BindableProperty.Create(nameof(CurrentStateSource), typeof(ImageSource), typeof(ImageButton), null);

        public static readonly BindableProperty DisabledSourceProperty =
            BindableProperty.Create(nameof(DisabledSource), typeof(ImageSource), typeof(ImageButton), null);

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ImageButton), null);

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(ImageButton), null);

        readonly SingleSubscriptionEnsurer<ICommand> commandSse;
        View viewWithTap;

        public ImageButton()
        {
            commandSse = new SingleSubscriptionEnsurer<ICommand>(
                c => c.CanExecuteChanged += Command_CanExecuteChanged,
                c => c.CanExecuteChanged -= Command_CanExecuteChanged
            );
        }

        [TypeConverter(typeof(/*FFImageLoading.Forms.*/ImageSourceConverter))]
        public ImageSource DisabledSource
        {
            get { return (ImageSource)GetValue(DisabledSourceProperty); }
            set { SetValue(DisabledSourceProperty, value); }
        }

        protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            if (propertyName == nameof(Command)) commandSse.EnsureUnsubscribed();
            base.OnPropertyChanging(propertyName);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(Command))
                commandSse.EnsureSubscribed(Command);
            else if (propertyName == nameof(this.IsEnabled) ||
                propertyName == nameof(this.Source) && IsEnabled ||
                propertyName == nameof(this.DisabledSource) && !IsEnabled
            ) base.OnPropertyChanged(nameof(this.CurrentStateSource));
        }

        [TypeConverter(typeof(/* FFImageLoading.Forms. */ ImageSourceConverter))]
        public ImageSource CurrentStateSource => IsEnabled ? Source : DisabledSource;

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public bool TapOnParent { get; set; }

        ICommand TransitionCommand
        {
            get
            {
                return new RelayCommandAsync(() => TaskHelper.RunOnUIThread(async () =>
                {
                    if (!IsEnabled) return;
                    AnchorX = 0.48;
                    AnchorY = 0.48;
                    await this.ScaleTo(0.8, 50, Easing.Linear);
                    await this.ScaleTo(1, 50, Easing.Linear);
                    XLog.Debug($"Tapped FileImageSource = {(Source as FileImageSource)?.File}");
                    Command?.Execute(CommandParameter);
                }));
            }
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
            View tapView = TapOnParent ? (Parent as View) : this;
            if (!object.ReferenceEquals(viewWithTap, tapView))
            {
                tapView.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = TransitionCommand
                });
                viewWithTap = tapView;
            }
        }

        void Command_CanExecuteChanged(object sender, System.EventArgs e)
        {
            var command = sender as ICommand;
            if (command == null) return;
            IsEnabled = command.CanExecute(CommandParameter);
        }
    }
}