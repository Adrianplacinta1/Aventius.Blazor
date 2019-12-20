#region Namespaces

using Aventius.Blazor.Graphics.Shared;
using Microsoft.AspNetCore.Components;

#endregion

namespace Aventius.Blazor.Graphics.Components
{
    public class RectangleBase : ShapeComponentBase
    {
        #region Parameters

        [Parameter]
        public int Height { get; set; }

        [Parameter]
        public int Width { get; set; }

        [Parameter]
        public int X { get; set; }

        [Parameter]
        public int Y { get; set; }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Set default parameter values if not already set
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            UpdateStyle();
        }

        /// <summary>
        /// Update the CSS for the rectangle
        /// </summary>
        protected void UpdateStyle()
        {
            // Generate the style
            Style = GenerateStyle(Position, X, Y, Width, Height, OutlineThickness, OutlineColour, Colour);
        }

        #endregion
    }
}
