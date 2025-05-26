# Welcome to C# Markup 2 for Uno Platform

This C# Markup 2 Presentation project was created with `dotnet new mcs-uno-markup2 --presentation mvvm --renderer native` (template version [`Modern.CSharp.Templates 3.2.0`](https://www.nuget.org/packages/Modern.CSharp.Templates/3.2.0))

## Get Started

To start working with the C# Markup 2 project, follow these steps:

1. In `WinUICsMarkupExamples.Presentation.csproj`, replace the `<TargetFrameworks ... />` elements with the `<TargetFrameworks ... />` elements from `WinUICsMarkupExamples.csproj`; both projects should have the same target frameworks
   (the generated C# Markup 2 project targets all platforms supported by Uno).

2. To quickly try out the C# Markup 2 `Example`, add it to your navigation.
   If you are using `Uno.Extensions.Navigation`, you can do this in `App.cs`:
   
   At the top, add:
   ```csharp
   using CsMarkup2Example = WinUICsMarkupExamples.Presentation.Example;
   ```

   In the `.UseNavigation` call, pass in `CsMarkup2Example.Routes.Register` for the `viewRouteBuilder`:
   ```csharp
   .UseNavigation(CsMarkup2Example.Routes.Register)
   ```

   And finally specify `CsMarkup2Example.Shell` in the `builder.NavigateAsync` call:
   ```csharp
   Host = await builder.NavigateAsync<CsMarkup2Example.Shell>();
   ```

3. If you target Windows native (WinAppSDK), **Rebuild** the `WinUICsMarkupExamples` project
   (the rebuild is to ensure that the Windows codegen for new pages has run; without that codegen you will get an exception on page display).

4. Run the `WinUICsMarkupExamples` project

## Add views and (view)models
You can use `New-View.ps1` (located in the `WinUICsMarkupExamples.Presentation` project folder) to quickly add new views - including (view)model, if applicable. See `New-View.ps1` for tips and parameters.

## C# Hot Reload - Automatic & Manual
Enjoy the fastest and most stable C# Hot Reload, with automatic UI updates, by debugging the **Desktop** target. This is a good reason to keep the Desktop target even if you don't deploy it.

C# Hot Reload does work to some extent in more target platforms, however the UI does not yet update automatically in all platforms, due to issues in Visual Studio.

The template contains code to overlay a 🔥 button in debug builds. This button lets you manually trigger a page rebuild, for cases where the IDE reports that C# hot reload succeeded but the UI does not update automatically.

## More info
See the [Readme in the GitHub CSharpForMarkup repo](https://github.com/VincentH-Net/CSharpForMarkup#c-markup-2) for an overview of features, usage examples and best practices

NJoy *concise* C# Markup 2 - the next-gen C# Markup for Uno!
