using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using System;
using System.Collections.Generic;
using System.Text;

namespace VtNetCore.Avalonia
{
    public partial class DefaultTheme : Styles
    {
        private readonly IServiceProvider? sp;
        public DefaultTheme(IServiceProvider? provider = null)
        {
            sp = provider;
            AvaloniaXamlLoader.Load(provider, this);
        }
    }
}
