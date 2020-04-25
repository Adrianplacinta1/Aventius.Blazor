#region Namespaces

using Aventius.Blazor.Graphics.Shared;
using Microsoft.AspNetCore.Components;

#endregion

namespace Aventius.Blazor.Graphics.Components
{
    public class TriangleBase : ShapeComponentBase
    {
        #region Parameters                       

        [Parameter]
        public int X1 { get; set; }

        [Parameter]
        public int X2 { get; set; }

        [Parameter]
        public int X3 { get; set; }

        [Parameter]
        public int Y1 { get; set; }

        [Parameter]
        public int Y2 { get; set; }

        [Parameter]
        public int Y3 { get; set; }

        #endregion        

        #region Override Methods

        protected override void UpdateStyle()
        {
            InternalStyle = $"stroke:{OutlineColour};stroke-width:{OutlineThickness};fill:{Colour};" + Style;            
        }

        #endregion                   
    }
}
