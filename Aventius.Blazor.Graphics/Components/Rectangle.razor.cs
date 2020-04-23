#region Namespaces

using Aventius.Blazor.Graphics.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

#endregion

namespace Aventius.Blazor.Graphics.Components
{
    public class RectangleBase : ShapeComponentBase
    {
        #region Parameters

        [Parameter]
        public string Class { get; set; }

        [Parameter]
        public int Height { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnMouseDown { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnMouseOut { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnMouseOver { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnMouseUp { get; set; }

        [Parameter]
        public string Style { get; set; }

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
            InternalStyle = GenerateStyle(Position, X, Y, Width, Height, OutlineThickness, OutlineColour, Colour) + ";" + Style;
        }

        #endregion
    }
}
