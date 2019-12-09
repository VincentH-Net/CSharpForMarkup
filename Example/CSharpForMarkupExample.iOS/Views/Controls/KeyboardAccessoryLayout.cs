using System.ComponentModel;
using UIKit;
using CSharpForMarkupExample.Views.Controls;
using CSharpForMarkupExample.iOS.Views.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(KeyboardAccessoryLayout), typeof(KeyboardAccessoryLayoutRenderer))]
[assembly: ExportRenderer(typeof(KeyboardAccessoryLayout.AccessoryGrid), typeof(KeyboardAccessoryLayoutRenderer.AccessoryGridRenderer))]

namespace CSharpForMarkupExample.iOS.Views.Controls
{
    public class KeyboardAccessoryLayoutRenderer : VisualElementRenderer<KeyboardAccessoryLayout>
    {
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            if (Element != null) { UpdateInputAccessoryViews(Element.Content, Element.Accessory); }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            switch (e.PropertyName)
            {
                case nameof(Element.Accessory):
                    UpdateInputAccessoryViews(Element.Content, Element.Accessory);
                    break;
            }
        }

        void UpdateInputAccessoryViews(View content, VisualElement accessory)
        {
            if (content == null || accessory == null) return;

            var accessoryRenderer = Platform.GetRenderer(accessory);
            if (accessoryRenderer == null) Platform.SetRenderer(accessory, accessoryRenderer = Platform.CreateRenderer(accessory));
            var accessoryUIView = accessoryRenderer.NativeView;
            if (accessoryUIView == null) return;

            foreach (var view in content.Descendants())
            {
                if (view is Entry entry)
                {
                    var uiTextField = (Platform.GetRenderer(entry) as EntryRenderer)?.Control;
                    if (uiTextField == null) continue;

                    if (!ReferenceEquals(uiTextField.InputAccessoryView, accessoryUIView))
                        uiTextField.InputAccessoryView = accessoryUIView;
                }
                else if (view is Editor editor)
                {
                    var uiTextField = (Platform.GetRenderer(editor) as EditorRenderer)?.Control;
                    if (uiTextField == null) continue;

                    if (!ReferenceEquals(uiTextField.InputAccessoryView, accessoryUIView))
                        uiTextField.InputAccessoryView = accessoryUIView;
                }
            }
        }

        public class AccessoryGridRenderer : VisualElementRenderer<KeyboardAccessoryLayout.AccessoryGrid>
        {
            protected override void UpdateNativeWidget()
            {
                base.UpdateNativeWidget();

                // iOS 8+ adds a height constraint to a view's InputAccessoryView when that view becomes the first responder, 
                // and sets the constraint value fixed to the InputAccessoryView height at that time.
                // To support resizing the accessory at any time, we update the automatically added height constraint's value
                // to match the accessory Frame height as set by the Xamarin Forms layout process.
                if (NativeView?.Constraints != null)
                {
                    foreach (var c in NativeView.Constraints)
                    {
                        if (c?.FirstAttribute == NSLayoutAttribute.Height && c.Constant != NativeView.Frame.Height)
                        {
                            c.Constant = NativeView.Frame.Height;
                            NativeView.LayoutIfNeeded();
                        }
                    }
                }
            }
        }
    }
}
