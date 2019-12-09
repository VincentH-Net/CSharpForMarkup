using QuickCross;
using System;
using Xamarin.Forms;

namespace CSharpForMarkupExample.Views.Controls
{

    public class KeyboardAccessoryLayout : Layout<View>
    {
        public static readonly BindableProperty AccessoryProperty = BindableProperty.Create(nameof(Accessory), typeof(AccessoryGrid), typeof(KeyboardAccessoryLayout), propertyChanged: OnAccessoryChanged);
        public static readonly BindableProperty ContentProperty = BindableProperty.Create(nameof(Content), typeof(View), typeof(KeyboardAccessoryLayout), propertyChanged: OnContentChanged);
        public static readonly BindableProperty LastInputViewAutomationIdProperty = BindableProperty.Create(nameof(LastInputViewAutomationId), typeof(string), typeof(KeyboardAccessoryLayout), defaultBindingMode: BindingMode.OneWayToSource);

        static void OnAccessoryChanged(BindableObject bindable, object oldValue, object newValue)
        {
            try { ((KeyboardAccessoryLayout)bindable).OnAccessoryChanged((AccessoryGrid)oldValue, (AccessoryGrid)newValue); }
            catch (Exception ex) { XLog.Trace(ex); }
        }

        static void OnContentChanged(BindableObject bindable, object oldValue, object newValue)
        {
            try { ((KeyboardAccessoryLayout)bindable).OnContentChanged((View)oldValue, (View)newValue); }
            catch (Exception ex) { XLog.Trace(ex); }
        }

        readonly bool isIos = Device.RuntimePlatform == Device.iOS;

        public View Content
        {
            get => (View)GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        // Note that any layout type could be used as base instead of Grid, 
        // as long as it's iOS renderer inherits from VisualElementRenderer<> so we can override UpdateNativeWidget
        public AccessoryGrid Accessory
        {
            get => (AccessoryGrid)GetValue(AccessoryProperty);
            set => SetValue(AccessoryProperty, value);
        }

        public string LastInputViewAutomationId
        {
            get => (string)GetValue(LastInputViewAutomationIdProperty);
            private set => SetValue(LastInputViewAutomationIdProperty, value);
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            var size = new Size();
            try
            {
                var content = Content;
                var accessory = Accessory;

                if (content?.IsVisible == true) {
                    size = content.Measure(widthConstraint, Double.PositiveInfinity, MeasureFlags.IncludeMargins).Request;
                }

                if (!isIos && accessory?.IsVisible == true)
                {
                    var accessorySize = accessory.Measure(widthConstraint, double.PositiveInfinity, MeasureFlags.IncludeMargins).Request;
                    size.Height += accessorySize.Height;
                    if (size.Width < accessorySize.Width) size.Width = accessorySize.Width;
                }
            } catch (Exception ex) { XLog.Trace(ex); }
            return new SizeRequest(size);
        }

        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            try {
                var content = Content;
                var accessory = Accessory;

                var accessorySize = new Size();
                if (accessory?.IsVisible == true)
                {
                    accessorySize = accessory.Measure(
                        isIos ? Application.Current.MainPage.Width : width,
                        isIos ? double.PositiveInfinity : height,
                        MeasureFlags.IncludeMargins
                    ).Request;
                }

                var maxContentHeight = isIos ? height : height - accessorySize.Height;

                var contentSize = new Size();
                if (content?.IsVisible == true) {
                    contentSize = content.Measure(
                        width,
                        maxContentHeight,
                        MeasureFlags.IncludeMargins
                    ).Request;
                }

                if (contentSize.Height > 0)
                    LayoutChildIntoBoundingRegion(
                        content, 
                        new Rectangle(x, y, width, maxContentHeight)
                    );

                if (accessorySize.Height > 0)
                    LayoutChildIntoBoundingRegion(
                        accessory, 
                        isIos ? new Rectangle(0, 0, Application.Current.MainPage.Width, accessorySize.Height) : 
                                new Rectangle(x, y + height - accessorySize.Height, width, accessorySize.Height)
                    );
            } catch (Exception ex) { XLog.Trace(ex); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (isIos && Accessory != null) SetInheritedBindingContext(Accessory, BindingContext);
            // Since on iOS we don't add the accessory to Children, we need to propagate BindingContext changes to the accessory and all its descendant elements ourselves.
        }

        void OnContentChanged(View oldValue, View newValue)
        {
            if (oldValue != null)
            {
                oldValue.DescendantAdded -= Content_DescendantAdded;
                oldValue.DescendantRemoved -= Content_DescendantRemoved;
                foreach (var element in oldValue.Descendants()) Content_DescendantRemoved(oldValue, new ElementEventArgs(element));
            }
            if (newValue != null)
            {
                foreach (var element in newValue.Descendants()) Content_DescendantAdded(newValue, new ElementEventArgs(element));
                newValue.DescendantAdded += Content_DescendantAdded;
                newValue.DescendantRemoved += Content_DescendantRemoved;
            }

            UpdateChild(oldValue, newValue);
        }

        void Content_DescendantAdded(object sender, ElementEventArgs e)
        {
            if (e.Element is InputView inputView)
            {
                inputView.Focused += InputView_Focused;
                inputView.Unfocused += InputView_Unfocused;
            }
        }

        void Content_DescendantRemoved(object sender, ElementEventArgs e)
        {
            if (e.Element is InputView inputView)
            {
                inputView.Focused -= InputView_Focused;
                inputView.Unfocused -= InputView_Unfocused;
            }
        }

        void InputView_Focused(object sender, FocusEventArgs e)
        {
            var inputView = (InputView)sender;
            LastInputViewAutomationId = inputView.AutomationId;
            if (!isIos) MakeAccessoryAppear();
        }

        void InputView_Unfocused(object sender, FocusEventArgs e)
        {
            if (!isIos) MakeAccessoryDisappear();
        }

        async void MakeAccessoryAppear()
        {
            var animatingAccessory = Accessory;
            if (animatingAccessory == null) return;

            double opacity = animatingAccessory.Opacity;
            try
            {
                ViewExtensions.CancelAnimations(animatingAccessory);

                if (!animatingAccessory.IsVisible)
                {
                    animatingAccessory.Opacity = 0.01;
                    animatingAccessory.IsVisible = true;
                    await animatingAccessory.FadeTo(opacity, 200, Easing.CubicIn);
                }
            }
            catch (Exception ex) { XLog.Trace(ex); }
            finally { animatingAccessory.Opacity = opacity; }
        }

        async void MakeAccessoryDisappear()
        {
            var animatingAccessory = Accessory;
            if (animatingAccessory == null) return;

            double translationY = animatingAccessory.TranslationY;
            try
            {
                ViewExtensions.CancelAnimations(animatingAccessory);

                var canceled = await animatingAccessory.TranslateTo(animatingAccessory.TranslationX, translationY + animatingAccessory.Height, 200, Easing.CubicIn);
                if (!canceled) animatingAccessory.IsVisible = false;
            }
            catch (Exception ex) { XLog.Trace(ex); }
            finally { animatingAccessory.TranslationY = translationY; }
        }

        void OnAccessoryChanged(AccessoryGrid oldValue, AccessoryGrid newValue)
        {
            if (isIos)
            {
                if (oldValue != null)
                    oldValue.MeasureInvalidated -= OnChildMeasureInvalidated; 

                if (newValue != null)
                {
                    newValue.MeasureInvalidated += OnChildMeasureInvalidated;
                    // When an element is added to Children, Xamarin Forms hooks/unhooks this event for us 
                    // Because we don't add the accessory to Children on iOS, we need to hook/unhook the event ourselves

                    newValue.Parent = this;
                    // This will cause Xamarin Forms to propagate the Platform and the BindingContext to the accessory and all its descendant elements.
                }
                InvalidateLayout();
            }
            else
            {
                if (newValue != null) newValue.IsVisible = oldValue?.IsVisible ?? false;
                UpdateChild(oldValue, newValue);
            }
        }

        void UpdateChild(View oldValue, View newValue)
        {
            var existingIndex = Children.IndexOf(oldValue);
            if (existingIndex >= 0)
            {
                if (newValue != null) Children[existingIndex] = newValue; else Children.RemoveAt(existingIndex);
            }
            else
            {
                if (newValue != null) Children.Add(newValue);
            }
        }

        public class AccessoryGrid : Grid { } // We need this class so we can provide an iOS renderer that overrides UpdateNativeWidget.
    }
}