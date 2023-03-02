# Tip: To execute in Visual Studio: open View|Terminal, type "New" + TAB to expand to ".\New-View.ps1", followed by the view name
Param(
    [Parameter(Mandatory, HelpMessage="The view name ('Page' suffix will be added)")]
    [string]
    $Name,

    [Parameter(HelpMessage="Create a view without a viewmodel")]
    [switch]
    $NoViewModel
)
dotnet new mcs-winui3-view -n $Name -o WinUICsMarkupExamples\Views --namespace WinUICsMarkupExamples.Views --noviewmodel $NoViewModel
