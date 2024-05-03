// Non-Uno global usings that would be generated if ImplicitUsings was enabled in the project file:
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

// Uno Navigation for use in models:
global using Uno.Extensions.Navigation;

// MVVM presentation pattern:
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;

// Include markup extension methods:
global using CSharpMarkup.WinUI;
global using CSharpMarkup.WinUI.Uno.Extensions.Navigation;
global using CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit;
global using CSharpMarkup.WinUI.Uno.Toolkit;
global using WinUICsMarkupExamples.Presentation.Core;

// Include markup helpers:
global using static CSharpMarkup.WinUI.Helpers;
global using static CSharpMarkup.WinUI.Uno.Extensions.Navigation.Helpers;
global using static CSharpMarkup.WinUI.Uno.Extensions.Navigation.Toolkit.Helpers;
global using static CSharpMarkup.WinUI.Uno.Toolkit.Helpers;
global using static WinUICsMarkupExamples.Presentation.Core.MarkupHelpers;

// Aliases for WinUI namespaces and types
// - Use to avoid including WinUI namespaces, which can cause ambiguities with the CSharpMarkup namespaces
// - Prefix namespaces and view type aliases with "UI"
global using UI = Microsoft.UI;
global using UIBindable = Microsoft.UI.Xaml.Data.BindableAttribute;
global using UIControls = Microsoft.UI.Xaml.Controls;
// - Non-view types, e.g. enums, don't need a UI prefix because they are not mirrored as types in the CSharpMarkup namespaces
global using BindingMode = Microsoft.UI.Xaml.Data.BindingMode;
global using Visibility = Microsoft.UI.Xaml.Visibility;

// Example-specific global usings:
global using static Microsoft.UI.Colors; // Or use an application specific palette class; can have dynamic values for theming
global using Tweet = WinUICsMarkupExamples.Presentation.Example.SearchViewModel.Tweet;
