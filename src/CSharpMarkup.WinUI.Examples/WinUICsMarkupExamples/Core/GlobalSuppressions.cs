// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

#if HAS_UNO
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Design", "CA1010:Generic interface should also be implemented", Justification = "Fix for inappropriate public IEnumerable in UNO Page", Scope = "namespaceanddescendants", Target = "~N:WinUICsMarkupExamples.Views")]
#endif
