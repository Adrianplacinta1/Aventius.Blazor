#region Namespaces

using Microsoft.AspNetCore.Components;

#endregion

namespace Aventius.Blazor.Graphics.Components
{
    public class RectangleBase : ComponentBase
    {
        #region Protected Properties

        protected string Style { get; set; }

        #endregion

        #region Parameters

        [Parameter]
        public string FillColour { get; set; }

        [Parameter]
        public int Height { get; set; }

        [Parameter]
        public int Width { get; set; }

        [Parameter]
        public string OutlineColour { get; set; }

        [Parameter]
        public int OutlineThickness { get; set; }

        [Parameter]
        public int X { get; set; }

        [Parameter]
        public int Y { get; set; }

        #endregion

        #region Protected Methods

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
            if (FillColour == null) FillColour = "white";
            if (OutlineColour == null) OutlineColour = "black";

            UpdateStyle();
        }

        /// <summary>
        /// Update the CSS for the rectangle
        /// </summary>
        protected void UpdateStyle()
        {
            Style = "position: absolute; left: " + X.ToString() + "px; top: " + Y.ToString() + "px; width: " + Width.ToString() + "px; height: " + Height.ToString() + "px; background-color: " + FillColour + "; border: solid " + OutlineThickness.ToString() + "px " + OutlineColour + ";";
        }

        #endregion
    }
}
