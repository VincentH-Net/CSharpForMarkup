# CSharpForMarkup [![Gitter](https://badges.gitter.im/CSharpForMarkup/community.svg)](https://gitter.im/CSharpForMarkup/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)
Use declarative style C# instead of XAML for Xamarin Forms UI.

*November 19th, 2020*
>## CSharpForMarkup for Forms 5 is now part of the Xamarin Community Toolkit
> [Xamarin Community Toolkint C# Markup](https://github.com/MicrosoftDocs/xamarin-communitytoolkit/blob/68fe0de991a99b364ed61e19bc280e3da94ff02e/docs/markup.md) targets Xamarin Forms 5 and includes all the new features from the [CSharpForMarkup Part 2 Forms PR](https://github.com/xamarin/Xamarin.Forms/pull/11428). C# Markup is a separate XCT NuGet package without any dependencies on other XCT packages; nothing but Forms 5 is required.

Using Xamarin Forms 5? Check out [XCT C# Markup](https://github.com/MicrosoftDocs/xamarin-communitytoolkit/blob/68fe0de991a99b364ed61e19bc280e3da94ff02e/docs/markup.md)!

Using Xamarin Forms 4.6 - 4.8? Use the [built-in C# Markup](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/csharp-markup).

**Why move to the Toolkit?**
 
As [announced](https://github.com/xamarin/Xamarin.Forms/issues/11857), Xamarin.Forms 5.0 is the last major version of Xamarin.Forms; new major features and development will be in .NET MAUI and the Xamarin Community Toolkit. Because C# Markup in Forms 4.6 - 4.8 is an experimental feature which will evolve significantly, the team proposed to move C# Markup to the Xamarin Community Toolkit where there is less red tape (than is added to Forms 5) to ensure rapid innovation can continue. Microsoft owns and supports the Xamarin Community Toolkit just like other Xamarin libraries. Also, C# Markup for MVU and MVVM will be kept aligned while MAUI is developed ([details](https://github.com/xamarin/Xamarin.Forms/issues/11857#issuecomment-687170063))

*July 15th, 2020*
>## C# Markup introduction post published on the Xamarin Blog
>See my [Introducing C# Markup for Xamarin.Forms](https://devblogs.microsoft.com/xamarin/c-sharp-markup-for-xamarin-forms/) guest post on the Xamarin blog to learn many C# Markup features while building a simple example.
>
>Here is the **2.5 minute video** showing it from beginning to end, using [LiveSharp](https://www.livesharp.net/) for hot-reload:
>
>[![Introducing Xamarin Forms C# Markup](https://img.youtube.com/vi/9YwWRvKqTpM/0.jpg)](https://www.youtube.com/watch?v=9YwWRvKqTpM "Introducing Xamarin Forms C# Markup")

*March 31st, 2020*
>## CSharpForMarkup is incorporated in Xamarin Forms 4.6!
>Thanks everyone for supporting the [Spec CSharpForMarkup PR on the Xamarin Forms repo](https://github.com/xamarin/Xamarin.Forms/pull/8342)!
>
>The PR received an unprecedented **200+** positive reactions (the nr 2 most popular Forms PR *ever* received just 40) and was merged into the Xamarin.Forms.Core 4.6 package in the `Xamarin.Forms.Markup` namespace.
>It is available in the current Xamarin Forms prerelease NuGet as an experimental feature. The documentation for the feature, which is called **"C# Markup"**, can be found in [docs.microsoft.com](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/csharp-markup).
>
>
>![CSharpForMarkupMergedInForms46](img/CSharpForMarkupMergedInForms46.png)
>
>**Note** some helpers were renamed in Xamarin.Forms.Markup, and quite a few helpers and improvements were added. CSharpForMarkup users are encouraged to migrate:
>see [Migrate from CSharpForMarkup to Xamarin.Forms.Markup](#Migrate-from-CSharpForMarkup-to-XamarinFormsMarkup). Thanks!
>
>**To Be Continued**
>
>C# Markup is already included in **.NET MAUI**, the exciting next evolution of Forms, which amongst many other innovations adds support for MVU. See this [C# Markup for MVU and MVVM](https://github.com/dotnet/maui/issues/119) Spec PR for next-gen features.
>
>In the mean time, I plan to add more features to C# Markup in new Xamarin Forms PR's. If you have issues or ideas, please add them in the Forms repo, include a link to [the PR](https://github.com/xamarin/Xamarin.Forms/pull/8342) and add CSharpForMarkup in the title. I also wil be working on tooling to support C# Markup (e.g. autoformat, convert XAML to C# Markup). Thanks!

## Why use C# for Markup?
Because **declarative UI** in C# has a much better developer experience than XAML, and reads either very similar or with more clarity.

Modern UI frameworks such as [Flutter](https://flutter.dev/) and [SwiftUI](https://developer.apple.com/xcode/swiftui/) offer declarative UI. Many developers really enjoy using a single powerful language for logic and markup. It makes things simpler and lets you use the same IDE features everywhere. CSharpForMarkup offers this for Xamarin Forms; no need to learn XAML.

If you do know XAML, you can keep using your knowledge, and gain productivity (because of the better IDE support for C# and because you don't need language bridging mechanisms). The syntax is very close to XAML and the same MVVM pattern is used; you should be familiar within a couple of hours.

## Declarative C# versus XAML
Compare this Entry markup:

![Entry X A M L](img/EntryXAML.png) XAML

![Entry C Sharp Long](img/EntryCSharpLong.png) C#, close to XAML

![Entry C Sharp Short](img/EntryCSharpShort.png) C#, shorter

See [Pro's and Con's](#declarative-c-versus-xaml-considerations) for a detailed comparison.

## Real World Examples

See CSharpForMarkup in action with [LiveSharp](https://github.com/OYIon/LiveSharp) for hot reload:

[![CSharpForMarkup with LiveSharp](img/CSharpForMarkupWithLiveSharp.png)](https://www.youtube.com/watch?v=HWxHTqzxT8Q "CSharpForMarkup with LiveSharp")

Check out this awesome Twitch stream by [David Ortinau](https://github.com/davidortinau) where [Ryan Davis](https://github.com/rdavisau) demonstrates these helpers - using hot reload!

[![CSharpForMarkup with Ryan Davis and David Ortinau](img/CSharpForMarkupOnTwitch.png)](https://youtu.be/Mw2F1aHY0tQ?t=1116 "CSharpForMarkup with Ryan Davis and David Ortinau")

CSharpForMarkup has been battle tested for usability and stability. It has been used for years to build production apps, e.g. the app in this video:

[![LiveSharp Production App](http://img.youtube.com/vi/50N1LL_Txe8/0.jpg)](http://www.youtube.com/watch?v=50N1LL_Txe8 "LiveSharp Production App")

How about some real-world source? Here is a simple registration code page (taken from a production app):

XAML:

![Page X A M L](img/PageXAML.png)

C#, close to XAML:

![Page C Sharp Long](img/PageCSharpLong.png)

By using more helper methods, you can further improve C# readability (but it will be less simular to the XAML):

![Page C Sharp Short](img/PageCSharpShort.png)

## Declarative C# versus XAML considerations 
Some observations that may help you if you like XAML but wonder whether declarative C# would work for you:

### Patterns and Tooling Pro's:
C#

![Compose Markup In CSharp](img/ComposeMarkupInCSharp.png)

- Simply **compose markup top-down** with **named** methods or properties for better maintainability of complex UI. It can read like a story (see example above)
- **Refactorings** like renaming a bindable property work reliably across logic and markup; zero chance of broken bindings.
- Cleanly separate UI markup from UI logic while encapsulating both in a single class with **partial class** files, e.g. `LoginPage.cs` + `LoginPage.logic.cs`.
- No need for separate [Value Converter](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/converters) classes. Inlining simple value converter code in your markup improves UI maintainability.
- No need for [XAML Triggers](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/triggers)
- No need for [XAML Compilation](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/xaml/xamlc)
- No need for [XAML Compiled Bindings](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/compiled-bindings). Bindings are fully compiled, including bindings that specify the `Source` property (which XAML can't compile).

### Reading Pro's:
C#
- Numbers and enums don't need quotes
- Constants don't need keyword or quotes (i.e. **name** vs **"\{StaticResource name\}"** )
- Can use calculated constants (i.e. **marginb = margina + 10**)
- Don't need parent class (i.e. **RowDefinitions** vs **Grid.RowDefinitions**)
- Designed for human readability

XAML
- Don't need enum name (i.e. **"End"** vs **LayoutOptions.End**)
- Don't need **new** keyword for each control
- Don't need **Children = \{** or **Content =** for child controls
- Designed for (visual designer) tools
  
### Editing Pro's:
C#
- No strings for properties: rename, code lens (where/not) used, compile time safety all just work
- Better IntelliSense (i.e. in XAML margins are strings)
- Simpler markup reuse (control builder method with parameters)
- Simple extensibility (i.e. don't need to write XAML extensions; customize your markup syntax with extension methods, creating your own DSL if you like)
- Better Diff & Merge
- **HotReload** in [LiveSharp](https://marketplace.visualstudio.com/items?itemName=ionoy.LiveSharp)

XAML
- Visual preview in IDE (very limited - no renderers etc)
- **HotReload** in [LiveXAML](https://www.livexaml.com/)

## Summary
The question of C# versus XAML is not so much "Why use C# for markup?" as it is "**Why use XAML for markup?**"

- Why would you want to hand-code an object serialization format?
- Why would you choose a different language for markup if it reads the same but has inferior IDE support?
- Why would you scatter your UI markup with language bridging mechanisms? (converters etc)

## Background
This repo resulted from this discussion on the Xamarin Forms forum:
[Using declarative style C# instead of XAML - should Xamarin redirect XAML efforts elsewhere?](https://forums.xamarin.com/discussion/123771/using-declarative-style-c-instead-of-xaml-should-xamarin-redirect-xaml-efforts-elsewhere?)

Imo XAML in Xamarin Forms exists for historical reasons, to convince developers that are familiar with other Microsoft XAML dialects to onboard. However, if used as above, developers can use their existing XAML knowledge in C#. It should not take more than a day to become accustomed to the small syntax changes, to gain productivity every day.

## Migrate from CSharpForMarkup helpers file to Markup in Xamarin.Forms 4.6 - 4.8
If you are using the original CSharpForMarkup helpers file from this repository, here is how you can migrate to markup Xamarin.Forms.

If you want to migrate to XCT C# Markup, first performs below steps and then continue with the migration steps described in the [XCT C# Markup docs](https://github.com/MicrosoftDocs/xamarin-communitytoolkit/blob/68fe0de991a99b364ed61e19bc280e3da94ff02e/docs/markup.md).

You can do these steps quickly with a regex replace or by renaming the helpers in `XamarinFormsMarkupExtensions.cs` and letting Visual Studio update your markup.
These are the renames:
- Helpers ending on `H` / `V` -> end on `Horizontal` / `Vertical`
- `Col` -> `Column` throughout
- `BoolNotConverter` -> `NotConverter`
- `EnumsForGridRowsAndColumns` -> `GridRowsColumns`
- `sourcePropertyName` parameter of the binding helpers -> `path`
- Namespace `CSharpForMarkup` -> `Xamarin.Forms.Markup`. After switching to the new namespace (you will need to update to Xamarin.Forms 4.6 or later) you can delete `XamarinFormsMarkupExtensions.cs`.

Other changes:
- To use `Left`/`TextLeft` or `Right`/`TextRight`, add either `using Xamarin.Forms.Markup.LeftToRight` or
`using Xamarin.Forms.Markup.RightToLeft`. For markup that is designed to support both left-to-right and right-to-left flow direction, it is recommended not to include either one of above namespaces, and instead use the new `Start`/`TextStart` & `End`/`TextEnd` helpers
- `Bind`, `Assign` and `Invoke` helpers now target `BindableObject` (was limited to `Element`)
- Default bindable properties were added for most built-in Forms types
- Added `DefaultBindableProperties.Register` and `DefaultBindableProperties.RegisterForCommand` to register default bindable properties for custom/3rd party view types
- Font helpers now support any IFontElement (was limited to Button, Label, Entry and Picker)
- Gesture recognizers: more built-in gesture recognizer types are supported, support to initialize gesture recognizers was added, support all possible binding parameters
- Converters: support for typed converter parameters and culture
- Added `BindCommand` helper to bind to default `Command` + `CommandParameter` parameters with a single method call
- Added `Columns.Define(width, width ...)` and `Rows.Define(height, height...)` overloads for `Grid` to support concise row / column definitions without using enums
- Removed `RowCol`; use `Row` + `Column` instead.
- Removed PlatformSpecificsExtensions - replace with guidance in PR description on how to use any platform specific with .Invoke
- Several bugfixes

NJoy!
