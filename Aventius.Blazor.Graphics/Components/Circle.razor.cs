#region Namespaces

using Microsoft.AspNetCore.Components;

#endregion

namespace Aventius.Blazor.Graphics.Components
{
    public class CircleBase : ComponentBase
    {
        #region Protected Properties

        public string Style { get; set; }

        #endregion

        #region Parameters

        [Parameter]
        public string FillColour { get; set; }

        [Parameter]
        public string OutlineColour { get; set; }

        [Parameter]
        public int OutlineThickness { get; set; }

        [Parameter]
        public int Radius { get; set; }

        [Parameter]
        public int X { get; set; }

        [Parameter]
        public int Y { get; set; }

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
            if (FillColour == null) FillColour = "white";
            if (OutlineColour == null) OutlineColour = "black";

            UpdateStyle();
        }

        /// <summary>
        /// Set the CSS for the circle
        /// </summary>
        protected void UpdateStyle()
        {
            Style = "position: absolute; left: " + X.ToString() + "px; top: " + Y.ToString() + "; height: " + (Radius * 2).ToString() + "px; width: " + (Radius * 2).ToString() + "px; background-color: " + FillColour + "; border: solid " + OutlineThickness.ToString() + "px " + OutlineColour + "; border-radius: 50%; display: inline-block;";
        }
    }
}
