# CSharpForMarkup
Use declarative style C# instead of XAML for Xamarin Forms UI.

All you need are [these simple helpers](src/XamarinFormsMarkupExtensions.cs); include the single .cs file in your project and off you go.

The helpers offer a fluent API with **Bind**, **Invoke**, **Assign**, **Row**, **Col**, inline converters, support for **using enums for Grid rows + columns** and more. Simple to change/extend.

## Why?
Because **declarative UI** in C# has a much better developer experience than XAML, and reads virtually the same.

Modern UI frameworks such as [Flutter](https://flutter.dev/) and [SwiftUI](https://developer.apple.com/xcode/swiftui/) offer declarative UI. These helpers offer the same for Xamarin Forms; no need to learn XAML.

If you do know XAML, you can keep using your knowledge, and gain productivity (because of the better IDE support for C# and because you don't need language bridging mechanisms). The syntax is very close to XAML and the same MVVM pattern is used; you should be familiar within a couple of hours.

## Declarative C# versus XAML
Compare this Entry markup:

![Entry X A M L](img/EntryXAML.png) XAML

![Entry C Sharp Long](img/EntryCSharpLong.png) C#, close to XAML

![Entry C Sharp Short](img/EntryCSharpShort.png) C#, shorter

Note that **Bind** knows the default bindable property for each view type; you can omit it in most cases.

Bind a command to any type of view using **gesture recognizers**:
```CSharp
new Label { Text = "Tap Me" }
.BindTapGesture (nameof(vm.TapCommand)) // Or use any type of gesture with Bind<TView, TGestureRecognizer>(...)
```

Pass inline converter code with **convert** and **convertBack** (type-safe):
```CSharp
new Label { Text = "Tree" }
.Bind (Label.MarginProperty, nameof(TreeNode.TreeDepth), convert: (int depth) => new Thickness(depth * 20, 0, 0, 0))
```
Re-use converter code with **FuncConverter**:
```CSharp
treeMarginConverter = new FuncConverter<int, Thickness>(depth => new Thickness(depth * 20, 0, 0, 0));
//...
new Label { Text = "Tree" }
.Bind(Label.MarginProperty, nameof(TreeNode.TreeDepth), converter: treeMarginConverter),
```


Use **Invoke** to execute code inline in your declarative markup:
```CSharp
new ListView { } .Invoke (l => l.ItemTapped += MyListView_ItemTapped)
```
Use **Assign** if you need to access a control from outside the markup:
```CSharp
new ListView { } .Assign (out MyListView),
```

How about a real-world page? Here is a simple registration code page (taken from a production app):

XAML:

![Page X A M L](img/PageXAML.png)

C#, close to XAML:

![Page C Sharp Long](img/PageCSharpLong.png)

By using more helper methods, you can further improve C# readability (but it will be less simular to the XAML):

![Page C Sharp Short](img/PageCSharpShort.png)

This markup follows some conventions. For each control:
- Bound properties are last, one per line
- The line before the bound properties is about layout, ordered inward: rows / cols, layout options, margin, size, padding, content alignment
- Before that are the other properties; any property that identifies the control's purpose comes first (e.g. Text or Placeholder)

You can also **use enums for Grid rows and columns** instead of numbers, so you don't have to renumber manually when you add or remove rows or columns. Readability and intent of the layout is also improved:

![Enums For Grid Rows And Columns](img/EnumsForGridRowsAndColumns.png)

Finally, these helpers also offer support for **Effects** and **Platform Specifics**.

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

NJoy!