#region Namespaces

using Microsoft.AspNetCore.Components;

#endregion

namespace Aventius.Blazor.Graphics.Shared
{
    public class ShapeComponentBase : ComponentBase
    {
        #region Protected Properties

        public string InternalStyle { get; set; }

        #endregion

        #region Parameters

        [Parameter]
        public string Colour { get; set; }

        [Parameter]
        public string OutlineColour { get; set; }

        [Parameter]
        public int OutlineThickness { get; set; }

        [Parameter]
        public Position Position { get; set; } = Position.Absolute;

        #endregion

        #region Protected Methods

        /// <summary>
        /// Translate the position into the string literal needed for css
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        protected string GetPosition(Position position)
        {
            switch (position)
            {
                case Position.Absolute: return "position:absolute;";
                case Position.Fixed: return "position:fixed;";
                case Position.Relative: return "position:relative;";
                case Position.Static: return "position:static;";
                case Position.Sticky: return "position:sticky;";

                default: return "position:absolute;";
            }
        }

        /// <summary>
        /// Helper method to generate css style
        /// </summary>
        /// <param name="position"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="borderWidth"></param>
        /// <param name="borderColour"></param>
        /// <param name="backgroundColor"></param>
        /// <returns></returns>
        public string GenerateStyle(Position position = Position.Absolute, int? left = null, int? top = null, int? width = null, int? height = null, int? borderWidth = null, string borderColour = "black", string backgroundColor = "white")
        {
            var style = GetPosition(position);

            if (left != null)
            {
                style += "left:" + left.ToString() + "px;";
            }

            if (top != null)
            {
                style += "top:" + top.ToString() + "px;";
            }

            if (width != null)
            {
                style += "width:" + width.ToString() + "px;";
            }

            if (height != null)
            {
                style += "height:" + height.ToString() + "px;";
            }

            if (borderWidth != null)
            {
                style += "border: solid " + borderWidth.ToString() + "px " + borderColour + ";";
            }

            style += "background-color:" + backgroundColor + ";";

            return style;
        }

        /// <summary>
        /// Set default parameter values if not already set
        /// </summary>
        protected override void OnParametersSet()
        {
            if (Colour == null) Colour = "black";
            if (OutlineColour == null) OutlineColour = "black";
        }

        #endregion
    }
}
