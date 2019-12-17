#region Namespaces

using Aventius.Blazor.Graphics.Shared;
using Microsoft.AspNetCore.Components;

#endregion

namespace Aventius.Blazor.Graphics.Components
{
    public class LineBase : ComponentBase
    {
        #region Protected Properties

        protected ElementReference LineElementReference { get; set; }
        protected string Style { get; set; }

        #endregion

        #region Parameters

        [Parameter]
        public string Colour { get; set; }

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

        /// <summary>
        /// Initialise the component
        /// </summary>
        protected override void OnInitialized()
        {
            Style = "";
        }

        /// <summary>
        /// Set default parameter values if not already set
        /// </summary>
        protected override void OnParametersSet()
        {
            if (Thickness == 0) Thickness = 1;
            if (Colour == null) Colour = "black";

            UpdateLineStyle();
        }

        /// <summary>
        /// Updates the style of the line
        /// </summary>
        /// <returns></returns>
        protected void UpdateLineStyle()
        {
            // Calculate the length and angle of the line
            var length = Calculations.DistanceBetweenTwoPoints(X1, Y1, X2, Y2);
            var angle = Calculations.AngleBetweenTwoPoints(X1, Y1, X2, Y2);

            // Now work out the center
            var cx = ((X1 + X2) / 2) - (length / 2);
            var cy = ((Y1 + Y2) / 2) - (Thickness / 2);

            // Finally set the style of the component
            Style = "position: absolute; line-height: 1px; height:" + Thickness.ToString() + "px; background-color: " + Colour + "; left:" + cx + "px; top:" + cy + "px; width:" + length + "px; -moz-transform:rotate(" + angle + "deg); -webkit-transform:rotate(" + angle + "deg); -o-transform:rotate(" + angle + "deg); -ms-transform:rotate(" + angle + "deg); transform:rotate(" + angle + "deg);";
        }
    }
}
