using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMarkup.Wpf // MenuItem
{
    public static partial class Helpers
    {
        /// <summary>Create a <see cref="Windows.Controls.MenuItem"/></summary>
        /// <remarks>Use named parameter to select this overload, e.g. <code>MenuItem (Header: "First", 1, 2, 3)</code></remarks>
        public static MenuItem MenuItem(object Header, params object[] Items) => MenuItem(Items).Header(Header);
    } 
}