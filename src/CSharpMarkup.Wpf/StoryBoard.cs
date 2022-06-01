using System.Runtime.CompilerServices;

namespace CSharpMarkup.Wpf
{
    public static partial class StoryboardExtensions
    {
        /// <summary>Set <see cref="Windows.Media.Animation.Storyboard.TargetName"/></summary>
        public static TTarget Storyboard_TargetName<TTarget>(this TTarget target, object? nameExpression = null, [CallerArgumentExpression("nameExpression")] string? nameExpressionString = default) where TTarget : DependencyObject
        { System.Windows.Media.Animation.Storyboard.SetTargetName(target.UI, Helpers.NameExpressionToName(nameExpressionString)); return target; }
    }
}