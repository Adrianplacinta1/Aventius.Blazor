#region Namespaces

using Aventius.Blazor.JsInterop.Dom;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

#endregion

namespace Aventius.Blazor.JsInterop
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

        public static async Task<Element> GetElementPropertiesAsync(this ElementReference elementRef)
        {
            return await JSRuntime.InvokeAsync<Element>(JSNamespace + ".getElementProperties", elementRef);
        }

        public static void InitialiseJSRuntime(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
        }

        #endregion
    }
}
