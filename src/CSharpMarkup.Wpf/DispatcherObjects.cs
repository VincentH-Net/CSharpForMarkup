// These are all types in System.Windows namespace (without it's Input and Automation subnamespaces) that are derived from DispatcherObjects but not from DependencyObject:

// Start of generated C# Markup API for the Microsoft.WindowsDesktop.App Object hierarchy
#if !GENERATE && WPF

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Windows = System.Windows;
using Stream = System.IO.Stream;
using ListSortDirection = System.ComponentModel.ListSortDirection;
using IEnumerable = System.Collections.IEnumerable;
using CultureInfo = System.Globalization.CultureInfo;
using RequestCachePolicy = System.Net.Cache.RequestCachePolicy;
using StringCollection = System.Collections.Specialized.StringCollection;
using Color = System.Windows.Media.Color;

namespace CSharpMarkup.Wpf // PresentationSource
{
    public partial class PresentationSource : DispatcherObject, IUI<System.Windows.PresentationSource>
    {
        Windows.PresentationSource ui;

        public new Windows.PresentationSource UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected PresentationSource() { }
    }

    public static partial class PresentationSourceExtensions
    {
        /// <summary>Set <see cref="Windows.PresentationSource.RootVisual"/></summary>
        public static TView RootVisual<TView>(this TView view, Windows.Media.Visual value) where TView : PresentationSource { view.UI.RootVisual = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // HwndSource
{
    public partial class HwndSource : PresentationSource, IUI<System.Windows.Interop.HwndSource>
    {
        Windows.Interop.HwndSource ui;

        public new Windows.Interop.HwndSource UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected HwndSource() { }
    }

    public static partial class HwndSourceExtensions
    {
        /// <summary>Set <see cref="Windows.Interop.HwndSource.RootVisual"/></summary>
        public static TView RootVisual<TView>(this TView view, Windows.Media.Visual value) where TView : HwndSource { view.UI.RootVisual = value; return view; }

        /// <summary>Set <see cref="Windows.Interop.HwndSource.SizeToContent"/></summary>
        public static TView SizeToContent<TView>(this TView view, Windows.SizeToContent value) where TView : HwndSource { view.UI.SizeToContent = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // HwndTarget
{
    public partial class HwndTarget : CompositionTarget, IUI<System.Windows.Interop.HwndTarget>
    {
        Windows.Interop.HwndTarget ui;

        public new Windows.Interop.HwndTarget UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected HwndTarget() { }
    }

    public static partial class HwndTargetExtensions
    {
        /// <summary>Set <see cref="Windows.Interop.HwndTarget.BackgroundColor"/></summary>
        public static TView BackgroundColor<TView>(this TView view, Color value) where TView : HwndTarget { view.UI.BackgroundColor = value; return view; }

        /// <summary>Set <see cref="Windows.Interop.HwndTarget.RenderMode"/></summary>
        public static TView RenderMode<TView>(this TView view, Windows.Interop.RenderMode value) where TView : HwndTarget { view.UI.RenderMode = value; return view; }

        /// <summary>Set <see cref="Windows.Interop.HwndTarget.RootVisual"/></summary>
        public static TView RootVisual<TView>(this TView view, Windows.Media.Visual value) where TView : HwndTarget { view.UI.RootVisual = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // CompositionTarget
{
    public partial class CompositionTarget : DispatcherObject, IUI<System.Windows.Media.CompositionTarget>
    {
        Windows.Media.CompositionTarget ui;

        public new Windows.Media.CompositionTarget UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected CompositionTarget() { }
    }

    public static partial class CompositionTargetExtensions
    {
        /// <summary>Set <see cref="Windows.Media.CompositionTarget.RootVisual"/></summary>
        public static TView RootVisual<TView>(this TView view, Windows.Media.Visual value) where TView : CompositionTarget { view.UI.RootVisual = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // DrawingContext
{
    public partial class DrawingContext : DispatcherObject, IUI<System.Windows.Media.DrawingContext>
    {
        Windows.Media.DrawingContext ui;

        public new Windows.Media.DrawingContext UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected DrawingContext() { }
    }
}

namespace CSharpMarkup.Wpf // MediaClock
{
    public partial class MediaClock : Clock, IUI<System.Windows.Media.MediaClock>
    {
        Windows.Media.MediaClock ui;

        public new Windows.Media.MediaClock UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected MediaClock() { }
    }
}

namespace CSharpMarkup.Wpf // StreamGeometryContext
{
    public partial class StreamGeometryContext : DispatcherObject, IUI<System.Windows.Media.StreamGeometryContext>
    {
        Windows.Media.StreamGeometryContext ui;

        public new Windows.Media.StreamGeometryContext UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected StreamGeometryContext() { }
    }
}

namespace CSharpMarkup.Wpf // VisualTarget
{
    public partial class VisualTarget : CompositionTarget, IUI<System.Windows.Media.VisualTarget>
    {
        Windows.Media.VisualTarget ui;

        public new Windows.Media.VisualTarget UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected VisualTarget() { }
    }
}

namespace CSharpMarkup.Wpf // AnimationClock
{
    public partial class AnimationClock : Clock, IUI<System.Windows.Media.Animation.AnimationClock>
    {
        Windows.Media.Animation.AnimationClock ui;

        public new Windows.Media.Animation.AnimationClock UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected AnimationClock() { }
    }
}

namespace CSharpMarkup.Wpf // Clock
{
    public partial class Clock : DispatcherObject, IUI<System.Windows.Media.Animation.Clock>
    {
        Windows.Media.Animation.Clock ui;

        public new Windows.Media.Animation.Clock UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected Clock() { }
    }
}

namespace CSharpMarkup.Wpf // ClockController
{
    public partial class ClockController : DispatcherObject, IUI<System.Windows.Media.Animation.ClockController>
    {
        Windows.Media.Animation.ClockController ui;

        public new Windows.Media.Animation.ClockController UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected ClockController() { }
    }

    public static partial class ClockControllerExtensions
    {
        /// <summary>Set <see cref="Windows.Media.Animation.ClockController.SpeedRatio"/></summary>
        public static TView SpeedRatio<TView>(this TView view, double value) where TView : ClockController { view.UI.SpeedRatio = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // ClockGroup
{
    public partial class ClockGroup : Clock, IUI<System.Windows.Media.Animation.ClockGroup>
    {
        Windows.Media.Animation.ClockGroup ui;

        public new Windows.Media.Animation.ClockGroup UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected ClockGroup() { }
    }
}

namespace CSharpMarkup.Wpf // BitmapDecoder
{
    public partial class BitmapDecoder : DispatcherObject, IUI<System.Windows.Media.Imaging.BitmapDecoder>
    {
        Windows.Media.Imaging.BitmapDecoder ui;

        public new Windows.Media.Imaging.BitmapDecoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected BitmapDecoder() { }
    }
}

namespace CSharpMarkup.Wpf // BitmapEncoder
{
    public partial class BitmapEncoder : DispatcherObject, IUI<System.Windows.Media.Imaging.BitmapEncoder>
    {
        Windows.Media.Imaging.BitmapEncoder ui;

        public new Windows.Media.Imaging.BitmapEncoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected BitmapEncoder() { }
    }

    public static partial class BitmapEncoderExtensions
    {
        /// <summary>Set <see cref="Windows.Media.Imaging.BitmapEncoder.ColorContexts"/></summary>
        public static TView ColorContexts<TView>(this TView view, ReadOnlyCollection<Windows.Media.ColorContext> value) where TView : BitmapEncoder { view.UI.ColorContexts = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.BitmapEncoder.Frames"/></summary>
        public static TView Frames<TView>(this TView view, IList<Windows.Media.Imaging.BitmapFrame> value) where TView : BitmapEncoder { view.UI.Frames = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.BitmapEncoder.Metadata"/></summary>
        public static TView Metadata<TView>(this TView view, Windows.Media.Imaging.BitmapMetadata value) where TView : BitmapEncoder { view.UI.Metadata = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.BitmapEncoder.Palette"/></summary>
        public static TView Palette<TView>(this TView view, Windows.Media.Imaging.BitmapPalette value) where TView : BitmapEncoder { view.UI.Palette = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.BitmapEncoder.Preview"/></summary>
        public static TView Preview<TView>(this TView view, Windows.Media.Imaging.BitmapSource value) where TView : BitmapEncoder { view.UI.Preview = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.BitmapEncoder.Thumbnail"/></summary>
        public static TView Thumbnail<TView>(this TView view, Windows.Media.Imaging.BitmapSource value) where TView : BitmapEncoder { view.UI.Thumbnail = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // BitmapPalette
{
    public partial class BitmapPalette : DispatcherObject, IUI<System.Windows.Media.Imaging.BitmapPalette>
    {
        Windows.Media.Imaging.BitmapPalette ui;

        public new Windows.Media.Imaging.BitmapPalette UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected BitmapPalette() { }
    }
}

namespace CSharpMarkup.Wpf // BmpBitmapDecoder
{
    public partial class BmpBitmapDecoder : BitmapDecoder, IUI<System.Windows.Media.Imaging.BmpBitmapDecoder>
    {
        Windows.Media.Imaging.BmpBitmapDecoder ui;

        public new Windows.Media.Imaging.BmpBitmapDecoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected BmpBitmapDecoder() { }
    }
}

namespace CSharpMarkup.Wpf // BmpBitmapEncoder
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Media.Imaging.BmpBitmapEncoder"/></summary>
        public static BmpBitmapEncoder BmpBitmapEncoder()
        {
            var ui = new Windows.Media.Imaging.BmpBitmapEncoder();
            return global::CSharpMarkup.Wpf.BmpBitmapEncoder.StartChain(ui);
        }
    }

    public partial class BmpBitmapEncoder : BitmapEncoder, IUI<System.Windows.Media.Imaging.BmpBitmapEncoder>
    {
        static BmpBitmapEncoder instance;

        internal static BmpBitmapEncoder StartChain(Windows.Media.Imaging.BmpBitmapEncoder ui)
        {
            if (instance == null) instance = new BmpBitmapEncoder();
            instance.UI = ui;
            return instance;
        }

        Windows.Media.Imaging.BmpBitmapEncoder ui;

        public new Windows.Media.Imaging.BmpBitmapEncoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Media.Imaging.BmpBitmapEncoder(BmpBitmapEncoder view) => view?.UI;

        public static implicit operator BmpBitmapEncoder(Windows.Media.Imaging.BmpBitmapEncoder ui) => BmpBitmapEncoder.StartChain(ui);

        protected BmpBitmapEncoder() { }
    }
}

namespace CSharpMarkup.Wpf // GifBitmapDecoder
{
    public partial class GifBitmapDecoder : BitmapDecoder, IUI<System.Windows.Media.Imaging.GifBitmapDecoder>
    {
        Windows.Media.Imaging.GifBitmapDecoder ui;

        public new Windows.Media.Imaging.GifBitmapDecoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected GifBitmapDecoder() { }
    }
}

namespace CSharpMarkup.Wpf // GifBitmapEncoder
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Media.Imaging.GifBitmapEncoder"/></summary>
        public static GifBitmapEncoder GifBitmapEncoder()
        {
            var ui = new Windows.Media.Imaging.GifBitmapEncoder();
            return global::CSharpMarkup.Wpf.GifBitmapEncoder.StartChain(ui);
        }
    }

    public partial class GifBitmapEncoder : BitmapEncoder, IUI<System.Windows.Media.Imaging.GifBitmapEncoder>
    {
        static GifBitmapEncoder instance;

        internal static GifBitmapEncoder StartChain(Windows.Media.Imaging.GifBitmapEncoder ui)
        {
            if (instance == null) instance = new GifBitmapEncoder();
            instance.UI = ui;
            return instance;
        }

        Windows.Media.Imaging.GifBitmapEncoder ui;

        public new Windows.Media.Imaging.GifBitmapEncoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Media.Imaging.GifBitmapEncoder(GifBitmapEncoder view) => view?.UI;

        public static implicit operator GifBitmapEncoder(Windows.Media.Imaging.GifBitmapEncoder ui) => GifBitmapEncoder.StartChain(ui);

        protected GifBitmapEncoder() { }
    }
}

namespace CSharpMarkup.Wpf // IconBitmapDecoder
{
    public partial class IconBitmapDecoder : BitmapDecoder, IUI<System.Windows.Media.Imaging.IconBitmapDecoder>
    {
        Windows.Media.Imaging.IconBitmapDecoder ui;

        public new Windows.Media.Imaging.IconBitmapDecoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected IconBitmapDecoder() { }
    }
}

namespace CSharpMarkup.Wpf // JpegBitmapDecoder
{
    public partial class JpegBitmapDecoder : BitmapDecoder, IUI<System.Windows.Media.Imaging.JpegBitmapDecoder>
    {
        Windows.Media.Imaging.JpegBitmapDecoder ui;

        public new Windows.Media.Imaging.JpegBitmapDecoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected JpegBitmapDecoder() { }
    }
}

namespace CSharpMarkup.Wpf // JpegBitmapEncoder
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Media.Imaging.JpegBitmapEncoder"/></summary>
        public static JpegBitmapEncoder JpegBitmapEncoder(O<bool> FlipHorizontal = default, O<bool> FlipVertical = default, O<int> QualityLevel = default, O<Windows.Media.Imaging.Rotation> Rotation = default)
        {
            var ui = new Windows.Media.Imaging.JpegBitmapEncoder();
            if (FlipHorizontal.HasValue) ui.FlipHorizontal = FlipHorizontal.Value;
            if (FlipVertical.HasValue) ui.FlipVertical = FlipVertical.Value;
            if (QualityLevel.HasValue) ui.QualityLevel = QualityLevel.Value;
            if (Rotation.HasValue) ui.Rotation = Rotation.Value;
            return global::CSharpMarkup.Wpf.JpegBitmapEncoder.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Media.Imaging.JpegBitmapEncoder"/></summary>
        public static JpegBitmapEncoder JpegBitmapEncoder()
        {
            var ui = new Windows.Media.Imaging.JpegBitmapEncoder();
            return global::CSharpMarkup.Wpf.JpegBitmapEncoder.StartChain(ui);
        }
    }

    public partial class JpegBitmapEncoder : BitmapEncoder, IUI<System.Windows.Media.Imaging.JpegBitmapEncoder>
    {
        static JpegBitmapEncoder instance;

        internal static JpegBitmapEncoder StartChain(Windows.Media.Imaging.JpegBitmapEncoder ui)
        {
            if (instance == null) instance = new JpegBitmapEncoder();
            instance.UI = ui;
            return instance;
        }

        Windows.Media.Imaging.JpegBitmapEncoder ui;

        public new Windows.Media.Imaging.JpegBitmapEncoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Media.Imaging.JpegBitmapEncoder(JpegBitmapEncoder view) => view?.UI;

        public static implicit operator JpegBitmapEncoder(Windows.Media.Imaging.JpegBitmapEncoder ui) => JpegBitmapEncoder.StartChain(ui);

        protected JpegBitmapEncoder() { }
    }

    public static partial class JpegBitmapEncoderExtensions
    {
        /// <summary>Set <see cref="Windows.Media.Imaging.JpegBitmapEncoder.FlipHorizontal"/></summary>
        public static TView FlipHorizontal<TView>(this TView view, bool value) where TView : JpegBitmapEncoder { view.UI.FlipHorizontal = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.JpegBitmapEncoder.FlipVertical"/></summary>
        public static TView FlipVertical<TView>(this TView view, bool value) where TView : JpegBitmapEncoder { view.UI.FlipVertical = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.JpegBitmapEncoder.QualityLevel"/></summary>
        public static TView QualityLevel<TView>(this TView view, int value) where TView : JpegBitmapEncoder { view.UI.QualityLevel = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.JpegBitmapEncoder.Rotation"/></summary>
        public static TView Rotation<TView>(this TView view, Windows.Media.Imaging.Rotation value) where TView : JpegBitmapEncoder { view.UI.Rotation = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // LateBoundBitmapDecoder
{
    public partial class LateBoundBitmapDecoder : BitmapDecoder, IUI<System.Windows.Media.Imaging.LateBoundBitmapDecoder>
    {
        Windows.Media.Imaging.LateBoundBitmapDecoder ui;

        public new Windows.Media.Imaging.LateBoundBitmapDecoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected LateBoundBitmapDecoder() { }
    }
}

namespace CSharpMarkup.Wpf // PngBitmapDecoder
{
    public partial class PngBitmapDecoder : BitmapDecoder, IUI<System.Windows.Media.Imaging.PngBitmapDecoder>
    {
        Windows.Media.Imaging.PngBitmapDecoder ui;

        public new Windows.Media.Imaging.PngBitmapDecoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected PngBitmapDecoder() { }
    }
}

namespace CSharpMarkup.Wpf // PngBitmapEncoder
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Media.Imaging.PngBitmapEncoder"/></summary>
        public static PngBitmapEncoder PngBitmapEncoder(O<Windows.Media.Imaging.PngInterlaceOption> Interlace = default)
        {
            var ui = new Windows.Media.Imaging.PngBitmapEncoder();
            if (Interlace.HasValue) ui.Interlace = Interlace.Value;
            return global::CSharpMarkup.Wpf.PngBitmapEncoder.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Media.Imaging.PngBitmapEncoder"/></summary>
        public static PngBitmapEncoder PngBitmapEncoder()
        {
            var ui = new Windows.Media.Imaging.PngBitmapEncoder();
            return global::CSharpMarkup.Wpf.PngBitmapEncoder.StartChain(ui);
        }
    }

    public partial class PngBitmapEncoder : BitmapEncoder, IUI<System.Windows.Media.Imaging.PngBitmapEncoder>
    {
        static PngBitmapEncoder instance;

        internal static PngBitmapEncoder StartChain(Windows.Media.Imaging.PngBitmapEncoder ui)
        {
            if (instance == null) instance = new PngBitmapEncoder();
            instance.UI = ui;
            return instance;
        }

        Windows.Media.Imaging.PngBitmapEncoder ui;

        public new Windows.Media.Imaging.PngBitmapEncoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Media.Imaging.PngBitmapEncoder(PngBitmapEncoder view) => view?.UI;

        public static implicit operator PngBitmapEncoder(Windows.Media.Imaging.PngBitmapEncoder ui) => PngBitmapEncoder.StartChain(ui);

        protected PngBitmapEncoder() { }
    }

    public static partial class PngBitmapEncoderExtensions
    {
        /// <summary>Set <see cref="Windows.Media.Imaging.PngBitmapEncoder.Interlace"/></summary>
        public static TView Interlace<TView>(this TView view, Windows.Media.Imaging.PngInterlaceOption value) where TView : PngBitmapEncoder { view.UI.Interlace = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // TiffBitmapDecoder
{
    public partial class TiffBitmapDecoder : BitmapDecoder, IUI<System.Windows.Media.Imaging.TiffBitmapDecoder>
    {
        Windows.Media.Imaging.TiffBitmapDecoder ui;

        public new Windows.Media.Imaging.TiffBitmapDecoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected TiffBitmapDecoder() { }
    }
}

namespace CSharpMarkup.Wpf // TiffBitmapEncoder
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Media.Imaging.TiffBitmapEncoder"/></summary>
        public static TiffBitmapEncoder TiffBitmapEncoder(O<Windows.Media.Imaging.TiffCompressOption> Compression = default)
        {
            var ui = new Windows.Media.Imaging.TiffBitmapEncoder();
            if (Compression.HasValue) ui.Compression = Compression.Value;
            return global::CSharpMarkup.Wpf.TiffBitmapEncoder.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Media.Imaging.TiffBitmapEncoder"/></summary>
        public static TiffBitmapEncoder TiffBitmapEncoder()
        {
            var ui = new Windows.Media.Imaging.TiffBitmapEncoder();
            return global::CSharpMarkup.Wpf.TiffBitmapEncoder.StartChain(ui);
        }
    }

    public partial class TiffBitmapEncoder : BitmapEncoder, IUI<System.Windows.Media.Imaging.TiffBitmapEncoder>
    {
        static TiffBitmapEncoder instance;

        internal static TiffBitmapEncoder StartChain(Windows.Media.Imaging.TiffBitmapEncoder ui)
        {
            if (instance == null) instance = new TiffBitmapEncoder();
            instance.UI = ui;
            return instance;
        }

        Windows.Media.Imaging.TiffBitmapEncoder ui;

        public new Windows.Media.Imaging.TiffBitmapEncoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Media.Imaging.TiffBitmapEncoder(TiffBitmapEncoder view) => view?.UI;

        public static implicit operator TiffBitmapEncoder(Windows.Media.Imaging.TiffBitmapEncoder ui) => TiffBitmapEncoder.StartChain(ui);

        protected TiffBitmapEncoder() { }
    }

    public static partial class TiffBitmapEncoderExtensions
    {
        /// <summary>Set <see cref="Windows.Media.Imaging.TiffBitmapEncoder.Compression"/></summary>
        public static TView Compression<TView>(this TView view, Windows.Media.Imaging.TiffCompressOption value) where TView : TiffBitmapEncoder { view.UI.Compression = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // WmpBitmapDecoder
{
    public partial class WmpBitmapDecoder : BitmapDecoder, IUI<System.Windows.Media.Imaging.WmpBitmapDecoder>
    {
        Windows.Media.Imaging.WmpBitmapDecoder ui;

        public new Windows.Media.Imaging.WmpBitmapDecoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected WmpBitmapDecoder() { }
    }
}

namespace CSharpMarkup.Wpf // WmpBitmapEncoder
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Media.Imaging.WmpBitmapEncoder"/></summary>
        public static WmpBitmapEncoder WmpBitmapEncoder(O<byte> AlphaDataDiscardLevel = default, O<byte> AlphaQualityLevel = default, O<bool> CompressedDomainTranscode = default, O<bool> FlipHorizontal = default, O<bool> FlipVertical = default, O<bool> FrequencyOrder = default, O<short> HorizontalTileSlices = default, O<bool> IgnoreOverlap = default, O<byte> ImageDataDiscardLevel = default, O<float> ImageQualityLevel = default, O<bool> InterleavedAlpha = default, O<bool> Lossless = default, O<byte> OverlapLevel = default, O<byte> QualityLevel = default, O<Windows.Media.Imaging.Rotation> Rotation = default, O<byte> SubsamplingLevel = default, O<bool> UseCodecOptions = default, O<short> VerticalTileSlices = default)
        {
            var ui = new Windows.Media.Imaging.WmpBitmapEncoder();
            if (AlphaDataDiscardLevel.HasValue) ui.AlphaDataDiscardLevel = AlphaDataDiscardLevel.Value;
            if (AlphaQualityLevel.HasValue) ui.AlphaQualityLevel = AlphaQualityLevel.Value;
            if (CompressedDomainTranscode.HasValue) ui.CompressedDomainTranscode = CompressedDomainTranscode.Value;
            if (FlipHorizontal.HasValue) ui.FlipHorizontal = FlipHorizontal.Value;
            if (FlipVertical.HasValue) ui.FlipVertical = FlipVertical.Value;
            if (FrequencyOrder.HasValue) ui.FrequencyOrder = FrequencyOrder.Value;
            if (HorizontalTileSlices.HasValue) ui.HorizontalTileSlices = HorizontalTileSlices.Value;
            if (IgnoreOverlap.HasValue) ui.IgnoreOverlap = IgnoreOverlap.Value;
            if (ImageDataDiscardLevel.HasValue) ui.ImageDataDiscardLevel = ImageDataDiscardLevel.Value;
            if (ImageQualityLevel.HasValue) ui.ImageQualityLevel = ImageQualityLevel.Value;
            if (InterleavedAlpha.HasValue) ui.InterleavedAlpha = InterleavedAlpha.Value;
            if (Lossless.HasValue) ui.Lossless = Lossless.Value;
            if (OverlapLevel.HasValue) ui.OverlapLevel = OverlapLevel.Value;
            if (QualityLevel.HasValue) ui.QualityLevel = QualityLevel.Value;
            if (Rotation.HasValue) ui.Rotation = Rotation.Value;
            if (SubsamplingLevel.HasValue) ui.SubsamplingLevel = SubsamplingLevel.Value;
            if (UseCodecOptions.HasValue) ui.UseCodecOptions = UseCodecOptions.Value;
            if (VerticalTileSlices.HasValue) ui.VerticalTileSlices = VerticalTileSlices.Value;
            return global::CSharpMarkup.Wpf.WmpBitmapEncoder.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Media.Imaging.WmpBitmapEncoder"/></summary>
        public static WmpBitmapEncoder WmpBitmapEncoder()
        {
            var ui = new Windows.Media.Imaging.WmpBitmapEncoder();
            return global::CSharpMarkup.Wpf.WmpBitmapEncoder.StartChain(ui);
        }
    }

    public partial class WmpBitmapEncoder : BitmapEncoder, IUI<System.Windows.Media.Imaging.WmpBitmapEncoder>
    {
        static WmpBitmapEncoder instance;

        internal static WmpBitmapEncoder StartChain(Windows.Media.Imaging.WmpBitmapEncoder ui)
        {
            if (instance == null) instance = new WmpBitmapEncoder();
            instance.UI = ui;
            return instance;
        }

        Windows.Media.Imaging.WmpBitmapEncoder ui;

        public new Windows.Media.Imaging.WmpBitmapEncoder UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Media.Imaging.WmpBitmapEncoder(WmpBitmapEncoder view) => view?.UI;

        public static implicit operator WmpBitmapEncoder(Windows.Media.Imaging.WmpBitmapEncoder ui) => WmpBitmapEncoder.StartChain(ui);

        protected WmpBitmapEncoder() { }
    }

    public static partial class WmpBitmapEncoderExtensions
    {
        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.AlphaDataDiscardLevel"/></summary>
        public static TView AlphaDataDiscardLevel<TView>(this TView view, byte value) where TView : WmpBitmapEncoder { view.UI.AlphaDataDiscardLevel = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.AlphaQualityLevel"/></summary>
        public static TView AlphaQualityLevel<TView>(this TView view, byte value) where TView : WmpBitmapEncoder { view.UI.AlphaQualityLevel = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.CompressedDomainTranscode"/></summary>
        public static TView CompressedDomainTranscode<TView>(this TView view, bool value) where TView : WmpBitmapEncoder { view.UI.CompressedDomainTranscode = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.FlipHorizontal"/></summary>
        public static TView FlipHorizontal<TView>(this TView view, bool value) where TView : WmpBitmapEncoder { view.UI.FlipHorizontal = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.FlipVertical"/></summary>
        public static TView FlipVertical<TView>(this TView view, bool value) where TView : WmpBitmapEncoder { view.UI.FlipVertical = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.FrequencyOrder"/></summary>
        public static TView FrequencyOrder<TView>(this TView view, bool value) where TView : WmpBitmapEncoder { view.UI.FrequencyOrder = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.HorizontalTileSlices"/></summary>
        public static TView HorizontalTileSlices<TView>(this TView view, short value) where TView : WmpBitmapEncoder { view.UI.HorizontalTileSlices = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.IgnoreOverlap"/></summary>
        public static TView IgnoreOverlap<TView>(this TView view, bool value) where TView : WmpBitmapEncoder { view.UI.IgnoreOverlap = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.ImageDataDiscardLevel"/></summary>
        public static TView ImageDataDiscardLevel<TView>(this TView view, byte value) where TView : WmpBitmapEncoder { view.UI.ImageDataDiscardLevel = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.ImageQualityLevel"/></summary>
        public static TView ImageQualityLevel<TView>(this TView view, float value) where TView : WmpBitmapEncoder { view.UI.ImageQualityLevel = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.InterleavedAlpha"/></summary>
        public static TView InterleavedAlpha<TView>(this TView view, bool value) where TView : WmpBitmapEncoder { view.UI.InterleavedAlpha = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.Lossless"/></summary>
        public static TView Lossless<TView>(this TView view, bool value) where TView : WmpBitmapEncoder { view.UI.Lossless = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.OverlapLevel"/></summary>
        public static TView OverlapLevel<TView>(this TView view, byte value) where TView : WmpBitmapEncoder { view.UI.OverlapLevel = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.QualityLevel"/></summary>
        public static TView QualityLevel<TView>(this TView view, byte value) where TView : WmpBitmapEncoder { view.UI.QualityLevel = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.Rotation"/></summary>
        public static TView Rotation<TView>(this TView view, Windows.Media.Imaging.Rotation value) where TView : WmpBitmapEncoder { view.UI.Rotation = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.SubsamplingLevel"/></summary>
        public static TView SubsamplingLevel<TView>(this TView view, byte value) where TView : WmpBitmapEncoder { view.UI.SubsamplingLevel = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.UseCodecOptions"/></summary>
        public static TView UseCodecOptions<TView>(this TView view, bool value) where TView : WmpBitmapEncoder { view.UI.UseCodecOptions = value; return view; }

        /// <summary>Set <see cref="Windows.Media.Imaging.WmpBitmapEncoder.VerticalTileSlices"/></summary>
        public static TView VerticalTileSlices<TView>(this TView view, short value) where TView : WmpBitmapEncoder { view.UI.VerticalTileSlices = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // Application
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Application"/></summary>
        public static Application Application(O<Windows.Window> MainWindow = default, O<Windows.ResourceDictionary> Resources = default, O<Windows.ShutdownMode> ShutdownMode = default, O<Uri> StartupUri = default)
        {
            var ui = new Windows.Application();
            if (MainWindow.HasValue) ui.MainWindow = MainWindow.Value;
            if (Resources.HasValue) ui.Resources = Resources.Value;
            if (ShutdownMode.HasValue) ui.ShutdownMode = ShutdownMode.Value;
            if (StartupUri.HasValue) ui.StartupUri = StartupUri.Value;
            return global::CSharpMarkup.Wpf.Application.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Application"/></summary>
        public static Application Application()
        {
            var ui = new Windows.Application();
            return global::CSharpMarkup.Wpf.Application.StartChain(ui);
        }
    }

    public partial class Application : DispatcherObject, IUI<System.Windows.Application>
    {
        static Application instance;

        internal static Application StartChain(Windows.Application ui)
        {
            if (instance == null) instance = new Application();
            instance.UI = ui;
            return instance;
        }

        Windows.Application ui;

        public new Windows.Application UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Application(Application view) => view?.UI;

        public static implicit operator Application(Windows.Application ui) => Application.StartChain(ui);

        protected Application() { }
    }

    public static partial class ApplicationExtensions
    {
        /// <summary>Set <see cref="Windows.Application.MainWindow"/></summary>
        public static TView MainWindow<TView>(this TView view, Windows.Window value) where TView : Application { view.UI.MainWindow = value; return view; }

        /// <summary>Set <see cref="Windows.Application.Resources"/></summary>
        public static TView Resources<TView>(this TView view, Windows.ResourceDictionary value) where TView : Application { view.UI.Resources = value; return view; }

        /// <summary>Set <see cref="Windows.Application.ShutdownMode"/></summary>
        public static TView ShutdownMode<TView>(this TView view, Windows.ShutdownMode value) where TView : Application { view.UI.ShutdownMode = value; return view; }

        /// <summary>Set <see cref="Windows.Application.StartupUri"/></summary>
        public static TView StartupUri<TView>(this TView view, Uri value) where TView : Application { view.UI.StartupUri = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // DataTemplate
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.DataTemplate"/></summary>
        public static DataTemplate DataTemplate(O<object> DataType = default)
        {
            var ui = new Windows.DataTemplate();
            if (DataType.HasValue) ui.DataType = DataType.Value;
            return global::CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.DataTemplate"/></summary>
        public static DataTemplate DataTemplate()
        {
            var ui = new Windows.DataTemplate();
            return global::CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.DataTemplate"/></summary>
        public static DataTemplate DataTemplate(object dataType)
        {
            var ui = new Windows.DataTemplate(dataType);
            return global::CSharpMarkup.Wpf.DataTemplate.StartChain(ui);
        }
    }

    public partial class DataTemplate : FrameworkTemplate, IUI<System.Windows.DataTemplate>
    {
        static DataTemplate instance;

        internal static DataTemplate StartChain(Windows.DataTemplate ui)
        {
            if (instance == null) instance = new DataTemplate();
            instance.UI = ui;
            return instance;
        }

        Windows.DataTemplate ui;

        public new Windows.DataTemplate UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.DataTemplate(DataTemplate view) => view?.UI;

        public static implicit operator DataTemplate(Windows.DataTemplate ui) => DataTemplate.StartChain(ui);

        protected DataTemplate() { }
    }

    public static partial class DataTemplateExtensions
    {
        /// <summary>Set <see cref="Windows.DataTemplate.DataType"/></summary>
        public static TView DataType<TView>(this TView view, object value) where TView : DataTemplate { view.UI.DataType = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // FrameworkTemplate
{
    public partial class FrameworkTemplate : DispatcherObject, IUI<System.Windows.FrameworkTemplate>
    {
        Windows.FrameworkTemplate ui;

        public new Windows.FrameworkTemplate UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected FrameworkTemplate() { }
    }

    public static partial class FrameworkTemplateExtensions
    {
        /// <summary>Set <see cref="Windows.FrameworkTemplate.Resources"/></summary>
        public static TView Resources<TView>(this TView view, Windows.ResourceDictionary value) where TView : FrameworkTemplate { view.UI.Resources = value; return view; }

        /// <summary>Set <see cref="Windows.FrameworkTemplate.Template"/></summary>
        public static TView Template<TView>(this TView view, Windows.TemplateContent value) where TView : FrameworkTemplate { view.UI.Template = value; return view; }

        /// <summary>Set <see cref="Windows.FrameworkTemplate.VisualTree"/></summary>
        public static TView VisualTree<TView>(this TView view, Windows.FrameworkElementFactory value) where TView : FrameworkTemplate { view.UI.VisualTree = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // HierarchicalDataTemplate
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.HierarchicalDataTemplate"/></summary>
        public static HierarchicalDataTemplate HierarchicalDataTemplate(O<int> AlternationCount = default, O<Windows.Data.BindingGroup> ItemBindingGroup = default, O<Windows.Style> ItemContainerStyle = default, O<Windows.Controls.StyleSelector> ItemContainerStyleSelector = default, O<Windows.Data.BindingBase> ItemsSource = default, O<string> ItemStringFormat = default, O<Windows.DataTemplate> ItemTemplate = default, O<Windows.Controls.DataTemplateSelector> ItemTemplateSelector = default)
        {
            var ui = new Windows.HierarchicalDataTemplate();
            if (AlternationCount.HasValue) ui.AlternationCount = AlternationCount.Value;
            if (ItemBindingGroup.HasValue) ui.ItemBindingGroup = ItemBindingGroup.Value;
            if (ItemContainerStyle.HasValue) ui.ItemContainerStyle = ItemContainerStyle.Value;
            if (ItemContainerStyleSelector.HasValue) ui.ItemContainerStyleSelector = ItemContainerStyleSelector.Value;
            if (ItemsSource.HasValue) ui.ItemsSource = ItemsSource.Value;
            if (ItemStringFormat.HasValue) ui.ItemStringFormat = ItemStringFormat.Value;
            if (ItemTemplate.HasValue) ui.ItemTemplate = ItemTemplate.Value;
            if (ItemTemplateSelector.HasValue) ui.ItemTemplateSelector = ItemTemplateSelector.Value;
            return global::CSharpMarkup.Wpf.HierarchicalDataTemplate.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.HierarchicalDataTemplate"/></summary>
        public static HierarchicalDataTemplate HierarchicalDataTemplate()
        {
            var ui = new Windows.HierarchicalDataTemplate();
            return global::CSharpMarkup.Wpf.HierarchicalDataTemplate.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.HierarchicalDataTemplate"/></summary>
        public static HierarchicalDataTemplate HierarchicalDataTemplate(object dataType)
        {
            var ui = new Windows.HierarchicalDataTemplate(dataType);
            return global::CSharpMarkup.Wpf.HierarchicalDataTemplate.StartChain(ui);
        }
    }

    public partial class HierarchicalDataTemplate : DataTemplate, IUI<System.Windows.HierarchicalDataTemplate>
    {
        static HierarchicalDataTemplate instance;

        internal static HierarchicalDataTemplate StartChain(Windows.HierarchicalDataTemplate ui)
        {
            if (instance == null) instance = new HierarchicalDataTemplate();
            instance.UI = ui;
            return instance;
        }

        Windows.HierarchicalDataTemplate ui;

        public new Windows.HierarchicalDataTemplate UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.HierarchicalDataTemplate(HierarchicalDataTemplate view) => view?.UI;

        public static implicit operator HierarchicalDataTemplate(Windows.HierarchicalDataTemplate ui) => HierarchicalDataTemplate.StartChain(ui);

        protected HierarchicalDataTemplate() { }
    }

    public static partial class HierarchicalDataTemplateExtensions
    {
        /// <summary>Set <see cref="Windows.HierarchicalDataTemplate.AlternationCount"/></summary>
        public static TView AlternationCount<TView>(this TView view, int value) where TView : HierarchicalDataTemplate { view.UI.AlternationCount = value; return view; }

        /// <summary>Set <see cref="Windows.HierarchicalDataTemplate.ItemBindingGroup"/></summary>
        public static TView ItemBindingGroup<TView>(this TView view, Windows.Data.BindingGroup value) where TView : HierarchicalDataTemplate { view.UI.ItemBindingGroup = value; return view; }

        /// <summary>Set <see cref="Windows.HierarchicalDataTemplate.ItemContainerStyle"/></summary>
        public static TView ItemContainerStyle<TView>(this TView view, Windows.Style value) where TView : HierarchicalDataTemplate { view.UI.ItemContainerStyle = value; return view; }

        /// <summary>Set <see cref="Windows.HierarchicalDataTemplate.ItemContainerStyleSelector"/></summary>
        public static TView ItemContainerStyleSelector<TView>(this TView view, Windows.Controls.StyleSelector value) where TView : HierarchicalDataTemplate { view.UI.ItemContainerStyleSelector = value; return view; }

        /// <summary>Set <see cref="Windows.HierarchicalDataTemplate.ItemsSource"/></summary>
        public static TView ItemsSource<TView>(this TView view, Windows.Data.BindingBase value) where TView : HierarchicalDataTemplate { view.UI.ItemsSource = value; return view; }

        /// <summary>Set <see cref="Windows.HierarchicalDataTemplate.ItemStringFormat"/></summary>
        public static TView ItemStringFormat<TView>(this TView view, string value) where TView : HierarchicalDataTemplate { view.UI.ItemStringFormat = value; return view; }

        /// <summary>Set <see cref="Windows.HierarchicalDataTemplate.ItemTemplate"/></summary>
        public static TView ItemTemplate<TView>(this TView view, Windows.DataTemplate value) where TView : HierarchicalDataTemplate { view.UI.ItemTemplate = value; return view; }

        /// <summary>Set <see cref="Windows.HierarchicalDataTemplate.ItemTemplateSelector"/></summary>
        public static TView ItemTemplateSelector<TView>(this TView view, Windows.Controls.DataTemplateSelector value) where TView : HierarchicalDataTemplate { view.UI.ItemTemplateSelector = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // LostFocusEventManager
{
    public partial class LostFocusEventManager : WeakEventManager, IUI<System.Windows.LostFocusEventManager>
    {
        Windows.LostFocusEventManager ui;

        public new Windows.LostFocusEventManager UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected LostFocusEventManager() { }
    }
}

namespace CSharpMarkup.Wpf // Style
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style(O<Windows.Style> BasedOn = default, O<Windows.ResourceDictionary> Resources = default, O<Type> TargetType = default)
        {
            var ui = new Windows.Style();
            if (BasedOn.HasValue) ui.BasedOn = BasedOn.Value;
            if (Resources.HasValue) ui.Resources = Resources.Value;
            if (TargetType.HasValue) ui.TargetType = TargetType.Value;
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style()
        {
            var ui = new Windows.Style();
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style(Type targetType)
        {
            var ui = new Windows.Style(targetType);
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Style"/></summary>
        public static Style Style(Type targetType, Windows.Style basedOn)
        {
            var ui = new Windows.Style(targetType, basedOn);
            return global::CSharpMarkup.Wpf.Style.StartChain(ui);
        }
    }

    public partial class Style : DispatcherObject, IUI<System.Windows.Style>
    {
        static Style instance;

        internal static Style StartChain(Windows.Style ui)
        {
            if (instance == null) instance = new Style();
            instance.UI = ui;
            return instance;
        }

        Windows.Style ui;

        public new Windows.Style UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Style(Style view) => view?.UI;

        public static implicit operator Style(Windows.Style ui) => Style.StartChain(ui);

        protected Style() { }
    }

    public static partial class StyleExtensions
    {
        /// <summary>Set <see cref="Windows.Style.BasedOn"/></summary>
        public static TView BasedOn<TView>(this TView view, Windows.Style value) where TView : Style { view.UI.BasedOn = value; return view; }

        /// <summary>Set <see cref="Windows.Style.Resources"/></summary>
        public static TView Resources<TView>(this TView view, Windows.ResourceDictionary value) where TView : Style { view.UI.Resources = value; return view; }

        /// <summary>Set <see cref="Windows.Style.TargetType"/></summary>
        public static TView TargetType<TView>(this TView view, Type value) where TView : Style { view.UI.TargetType = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // AnnotationService
{
    public partial class AnnotationService : DispatcherObject, IUI<System.Windows.Annotations.AnnotationService>
    {
        Windows.Annotations.AnnotationService ui;

        public new Windows.Annotations.AnnotationService UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected AnnotationService() { }
    }
}

namespace CSharpMarkup.Wpf // ControlTemplate
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Controls.ControlTemplate"/></summary>
        public static ControlTemplate ControlTemplate(O<Type> TargetType = default)
        {
            var ui = new Windows.Controls.ControlTemplate();
            if (TargetType.HasValue) ui.TargetType = TargetType.Value;
            return global::CSharpMarkup.Wpf.ControlTemplate.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Controls.ControlTemplate"/></summary>
        public static ControlTemplate ControlTemplate()
        {
            var ui = new Windows.Controls.ControlTemplate();
            return global::CSharpMarkup.Wpf.ControlTemplate.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Controls.ControlTemplate"/></summary>
        public static ControlTemplate ControlTemplate(Type targetType)
        {
            var ui = new Windows.Controls.ControlTemplate(targetType);
            return global::CSharpMarkup.Wpf.ControlTemplate.StartChain(ui);
        }
    }

    public partial class ControlTemplate : FrameworkTemplate, IUI<System.Windows.Controls.ControlTemplate>
    {
        static ControlTemplate instance;

        internal static ControlTemplate StartChain(Windows.Controls.ControlTemplate ui)
        {
            if (instance == null) instance = new ControlTemplate();
            instance.UI = ui;
            return instance;
        }

        Windows.Controls.ControlTemplate ui;

        public new Windows.Controls.ControlTemplate UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Controls.ControlTemplate(ControlTemplate view) => view?.UI;

        public static implicit operator ControlTemplate(Windows.Controls.ControlTemplate ui) => ControlTemplate.StartChain(ui);

        protected ControlTemplate() { }
    }

    public static partial class ControlTemplateExtensions
    {
        /// <summary>Set <see cref="Windows.Controls.ControlTemplate.TargetType"/></summary>
        public static TView TargetType<TView>(this TView view, Type value) where TView : ControlTemplate { view.UI.TargetType = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // ItemCollection
{
    public partial class ItemCollection : CollectionView, IUI<System.Windows.Controls.ItemCollection>
    {
        Windows.Controls.ItemCollection ui;

        public new Windows.Controls.ItemCollection UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected ItemCollection() { }
    }

    public static partial class ItemCollectionExtensions
    {
        /// <summary>Set <see cref="Windows.Controls.ItemCollection.Filter"/></summary>
        public static TView Filter<TView>(this TView view, Predicate<object> value) where TView : ItemCollection { view.UI.Filter = value; return view; }

        /// <summary>Set <see cref="Windows.Controls.ItemCollection.IsLiveFiltering"/></summary>
        public static TView IsLiveFiltering<TView>(this TView view, bool? value) where TView : ItemCollection { view.UI.IsLiveFiltering = value; return view; }

        /// <summary>Set <see cref="Windows.Controls.ItemCollection.IsLiveGrouping"/></summary>
        public static TView IsLiveGrouping<TView>(this TView view, bool? value) where TView : ItemCollection { view.UI.IsLiveGrouping = value; return view; }

        /// <summary>Set <see cref="Windows.Controls.ItemCollection.IsLiveSorting"/></summary>
        public static TView IsLiveSorting<TView>(this TView view, bool? value) where TView : ItemCollection { view.UI.IsLiveSorting = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // ItemContainerTemplate
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Controls.ItemContainerTemplate"/></summary>
        public static ItemContainerTemplate ItemContainerTemplate()
        {
            var ui = new Windows.Controls.ItemContainerTemplate();
            return global::CSharpMarkup.Wpf.ItemContainerTemplate.StartChain(ui);
        }
    }

    public partial class ItemContainerTemplate : DataTemplate, IUI<System.Windows.Controls.ItemContainerTemplate>
    {
        static ItemContainerTemplate instance;

        internal static ItemContainerTemplate StartChain(Windows.Controls.ItemContainerTemplate ui)
        {
            if (instance == null) instance = new ItemContainerTemplate();
            instance.UI = ui;
            return instance;
        }

        Windows.Controls.ItemContainerTemplate ui;

        public new Windows.Controls.ItemContainerTemplate UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Controls.ItemContainerTemplate(ItemContainerTemplate view) => view?.UI;

        public static implicit operator ItemContainerTemplate(Windows.Controls.ItemContainerTemplate ui) => ItemContainerTemplate.StartChain(ui);

        protected ItemContainerTemplate() { }
    }
}

namespace CSharpMarkup.Wpf // ItemsPanelTemplate
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Controls.ItemsPanelTemplate"/></summary>
        public static ItemsPanelTemplate ItemsPanelTemplate()
        {
            var ui = new Windows.Controls.ItemsPanelTemplate();
            return global::CSharpMarkup.Wpf.ItemsPanelTemplate.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Controls.ItemsPanelTemplate"/></summary>
        public static ItemsPanelTemplate ItemsPanelTemplate(Windows.FrameworkElementFactory root)
        {
            var ui = new Windows.Controls.ItemsPanelTemplate(root);
            return global::CSharpMarkup.Wpf.ItemsPanelTemplate.StartChain(ui);
        }
    }

    public partial class ItemsPanelTemplate : FrameworkTemplate, IUI<System.Windows.Controls.ItemsPanelTemplate>
    {
        static ItemsPanelTemplate instance;

        internal static ItemsPanelTemplate StartChain(Windows.Controls.ItemsPanelTemplate ui)
        {
            if (instance == null) instance = new ItemsPanelTemplate();
            instance.UI = ui;
            return instance;
        }

        Windows.Controls.ItemsPanelTemplate ui;

        public new Windows.Controls.ItemsPanelTemplate UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Controls.ItemsPanelTemplate(ItemsPanelTemplate view) => view?.UI;

        public static implicit operator ItemsPanelTemplate(Windows.Controls.ItemsPanelTemplate ui) => ItemsPanelTemplate.StartChain(ui);

        protected ItemsPanelTemplate() { }
    }
}

namespace CSharpMarkup.Wpf // BindingListCollectionView
{
    public partial class BindingListCollectionView : CollectionView, IUI<System.Windows.Data.BindingListCollectionView>
    {
        Windows.Data.BindingListCollectionView ui;

        public new Windows.Data.BindingListCollectionView UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected BindingListCollectionView() { }
    }

    public static partial class BindingListCollectionViewExtensions
    {
        /// <summary>Set <see cref="Windows.Data.BindingListCollectionView.CustomFilter"/></summary>
        public static TView CustomFilter<TView>(this TView view, string value) where TView : BindingListCollectionView { view.UI.CustomFilter = value; return view; }

        /// <summary>Set <see cref="Windows.Data.BindingListCollectionView.GroupBySelector"/></summary>
        public static TView GroupBySelector<TView>(this TView view, Windows.Data.GroupDescriptionSelectorCallback value) where TView : BindingListCollectionView { view.UI.GroupBySelector = value; return view; }

        /// <summary>Set <see cref="Windows.Data.BindingListCollectionView.IsDataInGroupOrder"/></summary>
        public static TView IsDataInGroupOrder<TView>(this TView view, bool value) where TView : BindingListCollectionView { view.UI.IsDataInGroupOrder = value; return view; }

        /// <summary>Set <see cref="Windows.Data.BindingListCollectionView.IsLiveFiltering"/></summary>
        public static TView IsLiveFiltering<TView>(this TView view, bool? value) where TView : BindingListCollectionView { view.UI.IsLiveFiltering = value; return view; }

        /// <summary>Set <see cref="Windows.Data.BindingListCollectionView.IsLiveGrouping"/></summary>
        public static TView IsLiveGrouping<TView>(this TView view, bool? value) where TView : BindingListCollectionView { view.UI.IsLiveGrouping = value; return view; }

        /// <summary>Set <see cref="Windows.Data.BindingListCollectionView.IsLiveSorting"/></summary>
        public static TView IsLiveSorting<TView>(this TView view, bool? value) where TView : BindingListCollectionView { view.UI.IsLiveSorting = value; return view; }

        /// <summary>Set <see cref="Windows.Data.BindingListCollectionView.NewItemPlaceholderPosition"/></summary>
        public static TView NewItemPlaceholderPosition<TView>(this TView view, NewItemPlaceholderPosition value) where TView : BindingListCollectionView { view.UI.NewItemPlaceholderPosition = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // CollectionView
{
    public partial class CollectionView : DispatcherObject, IUI<System.Windows.Data.CollectionView>
    {
        Windows.Data.CollectionView ui;

        public new Windows.Data.CollectionView UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected CollectionView() { }
    }

    public static partial class CollectionViewExtensions
    {
        /// <summary>Set <see cref="Windows.Data.CollectionView.Culture"/></summary>
        public static TView Culture<TView>(this TView view, CultureInfo value) where TView : CollectionView { view.UI.Culture = value; return view; }

        /// <summary>Set <see cref="Windows.Data.CollectionView.Filter"/></summary>
        public static TView Filter<TView>(this TView view, Predicate<object> value) where TView : CollectionView { view.UI.Filter = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // DataChangedEventManager
{
    public partial class DataChangedEventManager : WeakEventManager, IUI<System.Windows.Data.DataChangedEventManager>
    {
        Windows.Data.DataChangedEventManager ui;

        public new Windows.Data.DataChangedEventManager UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected DataChangedEventManager() { }
    }
}

namespace CSharpMarkup.Wpf // ListCollectionView
{
    public partial class ListCollectionView : CollectionView, IUI<System.Windows.Data.ListCollectionView>
    {
        Windows.Data.ListCollectionView ui;

        public new Windows.Data.ListCollectionView UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected ListCollectionView() { }
    }

    public static partial class ListCollectionViewExtensions
    {
        /// <summary>Set <see cref="Windows.Data.ListCollectionView.CustomSort"/></summary>
        public static TView CustomSort<TView>(this TView view, IComparer value) where TView : ListCollectionView { view.UI.CustomSort = value; return view; }

        /// <summary>Set <see cref="Windows.Data.ListCollectionView.Filter"/></summary>
        public static TView Filter<TView>(this TView view, Predicate<object> value) where TView : ListCollectionView { view.UI.Filter = value; return view; }

        /// <summary>Set <see cref="Windows.Data.ListCollectionView.GroupBySelector"/></summary>
        public static TView GroupBySelector<TView>(this TView view, Windows.Data.GroupDescriptionSelectorCallback value) where TView : ListCollectionView { view.UI.GroupBySelector = value; return view; }

        /// <summary>Set <see cref="Windows.Data.ListCollectionView.IsDataInGroupOrder"/></summary>
        public static TView IsDataInGroupOrder<TView>(this TView view, bool value) where TView : ListCollectionView { view.UI.IsDataInGroupOrder = value; return view; }

        /// <summary>Set <see cref="Windows.Data.ListCollectionView.IsLiveFiltering"/></summary>
        public static TView IsLiveFiltering<TView>(this TView view, bool? value) where TView : ListCollectionView { view.UI.IsLiveFiltering = value; return view; }

        /// <summary>Set <see cref="Windows.Data.ListCollectionView.IsLiveGrouping"/></summary>
        public static TView IsLiveGrouping<TView>(this TView view, bool? value) where TView : ListCollectionView { view.UI.IsLiveGrouping = value; return view; }

        /// <summary>Set <see cref="Windows.Data.ListCollectionView.IsLiveSorting"/></summary>
        public static TView IsLiveSorting<TView>(this TView view, bool? value) where TView : ListCollectionView { view.UI.IsLiveSorting = value; return view; }

        /// <summary>Set <see cref="Windows.Data.ListCollectionView.NewItemPlaceholderPosition"/></summary>
        public static TView NewItemPlaceholderPosition<TView>(this TView view, NewItemPlaceholderPosition value) where TView : ListCollectionView { view.UI.NewItemPlaceholderPosition = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // FrameworkRichTextComposition
{
    public partial class FrameworkRichTextComposition : FrameworkTextComposition, IUI<System.Windows.Documents.FrameworkRichTextComposition>
    {
        Windows.Documents.FrameworkRichTextComposition ui;

        public new Windows.Documents.FrameworkRichTextComposition UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected FrameworkRichTextComposition() { }
    }
}

namespace CSharpMarkup.Wpf // FrameworkTextComposition
{
    public partial class FrameworkTextComposition : TextComposition, IUI<System.Windows.Documents.FrameworkTextComposition>
    {
        Windows.Documents.FrameworkTextComposition ui;

        public new Windows.Documents.FrameworkTextComposition UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected FrameworkTextComposition() { }
    }
}

namespace CSharpMarkup.Wpf // WeakEventManager
{
    public partial class WeakEventManager : DispatcherObject, IUI<System.Windows.WeakEventManager>
    {
        Windows.WeakEventManager ui;

        public new Windows.WeakEventManager UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        protected WeakEventManager() { }
    }
}

namespace CSharpMarkup.Wpf // DispatcherFrame
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Threading.DispatcherFrame"/></summary>
        public static DispatcherFrame DispatcherFrame(O<bool> Continue = default)
        {
            var ui = new Windows.Threading.DispatcherFrame();
            if (Continue.HasValue) ui.Continue = Continue.Value;
            return global::CSharpMarkup.Wpf.DispatcherFrame.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Threading.DispatcherFrame"/></summary>
        public static DispatcherFrame DispatcherFrame()
        {
            var ui = new Windows.Threading.DispatcherFrame();
            return global::CSharpMarkup.Wpf.DispatcherFrame.StartChain(ui);
        }

        /// <summary>Create a <see cref="Windows.Threading.DispatcherFrame"/></summary>
        public static DispatcherFrame DispatcherFrame(bool exitWhenRequested)
        {
            var ui = new Windows.Threading.DispatcherFrame(exitWhenRequested);
            return global::CSharpMarkup.Wpf.DispatcherFrame.StartChain(ui);
        }
    }

    public partial class DispatcherFrame : DispatcherObject, IUI<System.Windows.Threading.DispatcherFrame>
    {
        static DispatcherFrame instance;

        internal static DispatcherFrame StartChain(Windows.Threading.DispatcherFrame ui)
        {
            if (instance == null) instance = new DispatcherFrame();
            instance.UI = ui;
            return instance;
        }

        Windows.Threading.DispatcherFrame ui;

        public new Windows.Threading.DispatcherFrame UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }

        public static implicit operator Windows.Threading.DispatcherFrame(DispatcherFrame view) => view?.UI;

        public static implicit operator DispatcherFrame(Windows.Threading.DispatcherFrame ui) => DispatcherFrame.StartChain(ui);

        protected DispatcherFrame() { }
    }

    public static partial class DispatcherFrameExtensions
    {
        /// <summary>Set <see cref="Windows.Threading.DispatcherFrame.Continue"/></summary>
        public static TView Continue<TView>(this TView view, bool value) where TView : DispatcherFrame { view.UI.Continue = value; return view; }
    }
}

namespace CSharpMarkup.Wpf // DispatcherObject
{
    public partial class DispatcherObject: IUI<System.Windows.Threading.DispatcherObject>
    {
        public Windows.Threading.DispatcherObject UI { get; protected set; }

        protected DispatcherObject() { }
    }
}


#endif
// End of generated C# Markup API for the Microsoft.WindowsDesktop.App Object hierarchy
