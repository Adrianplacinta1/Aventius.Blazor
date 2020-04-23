#region Namespaces

using Aventius.Blazor.Graphics.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

#endregion

namespace Aventius.Blazor.Graphics.Components
{
    public class CircleBase : ShapeComponentBase
    {
        #region Parameters

        [Parameter]
        public string Class { get; set; }

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
        public int Radius { get; set; }

        [Parameter]
        public string Style { get; set; }

        [Parameter]
        public int X { get; set; }

        [Parameter]
        public int Y { get; set; }

        #endregion

        /// <summary>
        /// Update style after parameter values are set
        /// </summary>
        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            UpdateStyle();
        }

        /// <summary>
        /// Set the CSS for the circle
        /// </summary>
        protected void UpdateStyle()
        {
            // Calculate the diameter
            var diameter = Radius * 2;

            // Generate the style
            var style = GenerateStyle(Position, X, Y, diameter, diameter, OutlineThickness, OutlineColour, Colour);

            // And set the style :)
            InternalStyle = style + "border-radius:50%;display:inline-block;" + Style;
        }
    }
}
