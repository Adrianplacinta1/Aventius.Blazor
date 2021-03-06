﻿#region Namespaces

using Aventius.Blazor.Graphics.Shared;
using Microsoft.AspNetCore.Components;

#endregion

namespace Aventius.Blazor.Graphics.Components
{
    public class LineBase : ShapeComponentBase
    {
        #region Parameters        

        [Parameter]
        public int Thickness { get; set; }

        [Parameter]
        public int X1 { get; set; }

        [Parameter]
        public int X2 { get; set; }

        [Parameter]
        public int Y1 { get; set; }

        [Parameter]
        public int Y2 { get; set; }

        #endregion

        #region Protected Properties

        protected string OutlineStyle { get; set; }

        #endregion

        #region Override Methods

        protected override void UpdateStyle()
        {
            OutlineStyle = $"stroke:{OutlineColour};stroke-width:{Thickness + OutlineThickness};z-index:-99;" + Style;
            InternalStyle = $"stroke:{Colour};stroke-width:{Thickness};" + Style;
        }

        #endregion
    }
}
