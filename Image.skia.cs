#if !NETFX_CORE && !NETSTANDARD
using SkiaSharp.Views.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace P42.Uno.Image
{
    public partial class SvgImage : UserControl
    {
        void Build()
        {
            Content = new SKXamlCanvas
            {

            }
        }
    }
}
#endif