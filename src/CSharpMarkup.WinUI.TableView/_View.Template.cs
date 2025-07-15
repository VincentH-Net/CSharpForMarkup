﻿#if GENERATE
// Template approach: templates are compiling code written with typical examples of different kinds of UI views and properties.
// Give those specific example types generic replaceable placeholder names e.g. _ViewTypeName_
// Define named template code snippets with region comments e.g. #region MySnippetName ... #endregion
// Delimit replaceable placeholders with _.._ or /*_..._*/, e.g._placeholdername_ or /*_placeholdername_*/.
// Where needed to get the templates compiling:
// - Give type placeholders a specific type value with using, e.g.: using _placeholdername_ = specific_type;
// - Import types from namespaces that you do not want to fully inlude with individual using statements: using AType = DontIncludeTHsiNamespace.AType
//   This avoids ambiguities and serves to explicitly define the API dependencies "contract"

// TODO: Compare to templating approach in https://www.cazzulino.com/source-generators.html


// Below usings are used in the generated code for the entire WinUI for better readability;
// We define and use them in the templates themselves to ensure that the template code is unambiguous in the context of these usings.
#region NamespaceUsings
using System;
using System.Collections;
using System.Collections.Generic;
using CSharpMarkup.WinUI.GeneratedCodeUtilities;
using Xaml = Microsoft.UI.Xaml;
using TvUI = WinUI.TableView;
#endregion

// TODO: above aliases are workarounds for compile errors, investigate why and remove if possible

// Initialize some template placeholders with example values
using _PropertyType_ = System.Object;
using _AttachedPropertyType_ = System.Nullable<System.Double>;
using AttachedPropertyTargetType = Microsoft.UI.Xaml.DependencyObject; // Attached properties can target Markup types as well as non-Markup types, which is why AttachedPropertyTargetType is used in both _UIViewNamespace_ and _MarkupNamespace_

namespace _UIViewNamespace_
{
    using DependencyProperty = Microsoft.UI.Xaml.DependencyProperty;
    using ContentControl = Microsoft.UI.Xaml.Controls.ContentControl;
    using LayoutControl = Microsoft.UI.Xaml.Controls.Panel;
    using InlinesControl = Microsoft.UI.Xaml.Documents.Span;

    using _ViewBaseTypeName_ = Microsoft.UI.Xaml.FrameworkElement;

    public enum _EnumPropertyTypeName_ { _EnumPropertyValue_ }

    public partial class _ViewTypeName_ : _ViewBaseTypeName_
    {
        public _ViewTypeName_() { }

        public _PropertyType_ _PropertyName_ { get; set; }
        public static DependencyProperty _PropertyName_Property { get; }

        public static void Set_AttachedPropertyName_(AttachedPropertyTargetType target, _AttachedPropertyType_ value) { }
        public static DependencyProperty _AttachedPropertyName_Property { get; }
    }

    public partial class ContentView : ContentControl { public _PropertyType_ _PropertyName_ { get; set; } }

    public partial class LayoutView : LayoutControl { public List<_PropertyType_> _PropertyName_ { get; set; } }
}

namespace _MarkupNamespace_
{
    using CSharpMarkup.WinUI;
    using CSharpMarkup.WinUI.TableView;

    // Initialize computed template placeholders:
    using _UIViewType_ = _UIViewNamespace_._ViewTypeName_;
    using _UITargetType_ = _UIViewNamespace_._ViewTypeName_;
    using _MarkupViewType_ = _MarkupNamespace_._ViewTypeName_;
    using _ViewBaseTypeName_ = CSharpMarkup.WinUI.FrameworkElement; // This is to get the template compiling; _ViewBaseTypeName_ is defined in the _UIViewNamespace_
    using _UIEnumPropertyType_ = _UIViewNamespace_._EnumPropertyTypeName_;
    using _UIViewParameterType_ = Xaml.UIElement;
    // TODO: do we need this? using Microsoft.CodeAnalysis.CSharp.Syntax;

    public static partial class Helpers
    {
#region _ViewHelper_
        /// <summary>Create a <see cref="_UIViewType_"/></summary>_ViewHelperRemarks_
        /*_UnsupportedOSPlatformAttribute_*/public static/*_ViewHelperPartial_*/ _ViewTypeName_ _ViewTypeName_(/*_ViewHelperParameters_*/)
        {
            var ui = new _UIViewType_(/*_ViewHelperPassCtorParameters_*/);/*_ViewHelperStatements_*/
            return _MarkupViewType_.StartChain(ui);
        }
#endregion

#region _ViewHelperRemarks_
        /// <remarks>Remark: _ViewTypeName_().Bind() binds to <see cref="_DefaultBindPropertyFullName_"/></remarks>
#endregion

        public static ContentView ContentView(
#region _ContentViewHelperParameters_
            _PropertyType_ _PropertyName_
#endregion
        )
        {
            var ui = new _UIViewNamespace_.ContentView();
#region _ContentViewHelperStatements_
            if (_PropertyName_ != null) ui._PropertyName_ = _PropertyName_/*_AccessUI_*/;
#endregion
            return _MarkupNamespace_.ContentView.StartChain(ui);
        }

        // TODO: UNO supports WinUI views which have equivalent Markup UI type, plus native views
        // Markup UI types are created with a helper
        // A non-view type is created with new
        // To allow a native type to be added to a layout, below params type should be a base element/interface of all native view types and WinUI types alike
        // TODO: UNO what is that type for Android/iOS/...?
        public static LayoutView LayoutView(
#region _LayoutViewHelperParameters_
            params _PropertyType_[] _PropertyName_
#endregion
        )
        {
            var ui = new _UIViewNamespace_.LayoutView();
#region _LayoutViewHelperStatements_
            for (int i = 0; i < _PropertyName_.Length; i++)
            {
                var child = _PropertyName_[i];
                if (child == null) continue;

                var subChildren = Spreader<_PropertyType_>.ExtractChildren(child);
                if (subChildren is not null)
                    for (int j = 0; j < subChildren.Length; j++)
                        ui._PropertyName_.Add(subChildren[j]/*_AccessUI_*/);
                else
                    ui._PropertyName_.Add(child/*_AccessUI_*/);
            }
#endregion
            return _MarkupNamespace_.LayoutView.StartChain(ui);
        }

        public static LayoutView[] LayoutViewWithStructChildren(
#region _LayoutViewStructHelperParameters_
            params _PropertyType_[][] _PropertyName_
#endregion
        ) {
            var ui = new _UIViewNamespace_.LayoutView();
#region _LayoutViewStructHelperStatements_
        for (int i = 0; i < _PropertyName_.Length; i++)
        {
            for (int j = 0; j < _PropertyName_[i].Length; j++)
                ui._PropertyName_.Add(_PropertyName_[i][j]/*_AccessUI_*/);
        }
#endregion
            return new LayoutView[] { _MarkupNamespace_.LayoutView.StartChain(ui) };
        }
    }

    public partial class _ViewTypeName_ : _ViewBaseTypeName_/*_ViewInterfaces_*/
    {
#region ViewChain
        static _ViewTypeName_ instance;

        internal static _ViewTypeName_ StartChain(_UIViewType_ ui)
        {
            if (instance == null) instance = new _ViewTypeName_();
            instance.UI = ui;
            return instance;
        }
#endregion

        // Note that the above static viewchain pattern does not allow nesting chains of the same type.
        // We prevent that by only allowing child views to be passed in as parameters to the parent view helper;
        // This ensures that each child view chain is completed before the parent view chain is started,
        // so e.g. adding a child Grid to a parent Grid will not cause a nested Grid chain.
        // Since a markup expression is always evaluated synchronously and nesting chains of the same type is prevented, 
        // no more than one chain of a given type will be in use at any time.
        // TODO: Verify that apart from views, no other WinUI types can contain an instance of the same type.
        // TODO: some Inline - or its base TextElement - types may contain themselves - e.g. Span. See https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.documents.span?view=winrt-19041 -> so treat like a view

#region ViewUIPropertyWithBase
        _UIViewType_ ui;

        public new _UIViewType_ UI
        {
            get => ui;
            protected set => base.UI = ui = value;
        }
#endregion

#region ViewDefaultBindProperty
        /// <summary><see cref="_DefaultBindPropertyFullName_"/></summary>
        public/*_DefaultBindPropertyVirtual_*/ Xaml.DependencyProperty DefaultBindProperty => _DefaultBindPropertyFullName_;
#endregion

#region ViewImplicitParameter
        public static implicit operator _UIViewParameterType_(_ViewTypeName_ view) => view?.UI;
#endregion

#region ViewImplicitUI
        public static implicit operator _UIViewType_(_ViewTypeName_ view) => view?.UI;

        public static implicit operator _ViewTypeName_(_UIViewType_ ui) => _ViewTypeName_.StartChain(ui);
#endregion

#region ViewRequiredMembers
        public _ViewTypeName_ Invoke(Action<_UIViewType_> action) { action?.Invoke(UI); return this; }

        protected _ViewTypeName_() { }
#endregion

        Xaml.DependencyProperty _DefaultBindPropertyFullName_ = null; // Not part of template, only here to make the template compile
    }

    class MembersForViewWithoutBaseClass
    {
#region ViewUIPropertyWithoutBase
        public _UIViewType_ UI { get; protected set; }
#endregion
    }

    public static partial class _ViewTypeName_Extensions
    {
#region SetProperty
        /// <summary>Set <see cref="_UIViewType_._PropertyName_"/></summary>
        /*_UnsupportedOSPlatformAttribute_*/public static TView _PropertyName_/*_Suffix_*/<TView>(this TView view/*_PropertyParameters_*/) where TView : _ViewTypeName_ { view.UI._PropertyName_ = _PropertySetValue_; return view; }
#endregion

#region SetAttachedProperty
        /// <summary>Set <see cref="_UIViewType_._AttachedPropertyName_"/></summary>
        /*_UnsupportedOSPlatformAttribute_*/public static TTarget /*_DefiningViewPrefix_*/_AttachedPropertyName_/*_Suffix_*/<TTarget>(this TTarget target/*_PropertyParameters_*/) where TTarget : _PropertyTarget_
        { _UIViewType_.Set_AttachedPropertyName_(target/*_AccessUI_*/, _AttachedPropertySetValue_); return target; }
#endregion

#region SetAttachedProperties
        /// <summary>Set <see cref="_UIViewType_"/> attached properties</summary>
        public static TTarget _ViewTypeName_/*_Suffix_*/<TTarget>(this TTarget target
#region _AttachedPropertiesParameters_
            , _AttachedPropertyType_/*_Nullable_*/ _AttachedPropertyName_ = default
#endregion
        ) where TTarget : _PropertyTarget_
        {
#region _AttachedPropertiesAssignments_
            if (_AttachedPropertyName_ is not null) _UIViewType_.Set_AttachedPropertyName_(target/*_AccessUI_*/, _AttachedPropertyName_/*_GetValue_*/);
#endregion
            return target;
        }
#endregion

#region StartBindablePropertyChain
        /// <summary>Bind (or set enum value of) <see cref="_UIViewType_._PropertyName_"/></summary>
        /*_UnsupportedOSPlatformAttribute_*/public static DependencyProperty<TTarget, _PropertyType_> _DefiningViewPrefix__PropertyName_<TTarget>(this TTarget target) where TTarget : _PropertyTarget_
        => DependencyProperty<TTarget, _PropertyType_>.Get(target, _UIViewType_._PropertyName_Property);
#endregion

#region SetBindablePropertyChainEnumValue
        /// <summary>Set to <see cref="_UIEnumPropertyType_._EnumPropertyValue_"/></summary>
        public static TTarget _EnumPropertyValue_<TTarget>(this DependencyProperty<TTarget, _UIEnumPropertyType_> property) where TTarget : _PropertyTarget_
        => property.Set(_UIEnumPropertyType_._EnumPropertyValue_);
#endregion

        const string _PropertySetValue_ = null; // Not part of template, only here to make the template compile
        const double _AttachedPropertySetValue_ = 0;
    }

#region TypeConvertor
    readonly public partial struct _TypeConvertorName_
    {
        readonly _ConvertableType_ value;

        public _TypeConvertorName_(_ConvertableType_ value) => this.value = value;

        public static implicit operator _ConvertableType_(_TypeConvertorName_ value) => value.value;
        public static implicit operator _TypeConvertorName_(_ConvertableType_ value) => new(value);
    }
#endregion

#region TypeConvertorFromMarkup
    partial struct _TypeConvertorName_
    {
        public static implicit operator _TypeConvertorName_(_MarkupConvertableType_ value) => new(value.UI);
    }
#endregion

#region TypeConvertorFromString
    partial struct _TypeConvertorName_
    {
        static _TypeConvertorType_ fromStringconverter;
        static _TypeConvertorType_ FromStringConverter => fromStringconverter ??= new();

        public static implicit operator _TypeConvertorName_(string value) => (_ConvertableType_)_TypeConvertorName_.FromStringConverter.ConvertFromInvariantString(value);
    }
#endregion

    // Classes to get template compiling, not part of template
    public partial class _PropertyTarget_ : 
        _ViewTypeName_
#if !WINUI
        , AttachedPropertyTargetType 
#endif
    { }

    public partial class _NonViewPropertyTarget_ : Microsoft.UI.Xaml.DependencyObject { }

    public class ContentView { internal static ContentView StartChain(_UIViewNamespace_.ContentView ui) => null; }

    public class LayoutView { internal static LayoutView StartChain(_UIViewNamespace_.LayoutView ui) => null; }

    public class _TypeConvertorType_ { public object ConvertFromInvariantString(string _) => null; }

    public class _ConvertableType_ { }

    public class _MarkupConvertableType_ { public _ConvertableType_ UI => null; }
}
#endif