#region Namespaces

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

#endregion

namespace Aventius.Blazor.Graphics.Shared
{
    public abstract class ShapeComponentBase : ComponentBase
    {
        #region Protected Properties

        protected string InternalStyle { get; set; }

        #endregion

        #region Parameters

        [Parameter]
        public string Class { get; set; }

        [Parameter]
        public string Colour { get; set; }

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
        public string OutlineColour { get; set; }

        [Parameter]
        public int OutlineThickness { get; set; }

        [Parameter]
        public string Style { get; set; }

        #endregion

        #region Override Methods

        /// <summary>
        /// Set default parameter values if not already set
        /// </summary>
        protected override void OnParametersSet()
        {
            // Set default colours
            if (Colour == null) Colour = "black";
            if (OutlineColour == null) OutlineColour = "black";

            // Update the style
            UpdateStyle();
            StateHasChanged();

            base.OnParametersSet();
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// Implement this method to update the component style when parameter values change
        /// </summary>
        protected abstract void UpdateStyle();

        #endregion
    }
}
