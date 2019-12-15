#region Namespaces

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

#endregion

namespace Aventius.Blazor.Components.Primitives.JsInterop
{
    public static class JsInteropExtensions
    {
        #region Private Constants

        private const string JSNamespace = "AventiusJsFunctions";

        #endregion

        #region Private Properties

        private static IJSRuntime JSRuntime { get; set; }

        #endregion

        #region Public Extension Methods
        
        public static async Task<DOMElement> GetElementPropertiesAsync(this ElementReference elementRef)
        {
            return await JSRuntime.InvokeAsync<DOMElement>(JSNamespace + ".getElementProperties", elementRef);
        }

        public static void InitialiseJSRuntime(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
        }

        #endregion
    }
}
