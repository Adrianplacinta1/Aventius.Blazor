#region Namespaces

using Aventius.Blazor.JsInterop.DOM;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

#endregion

namespace Aventius.Blazor.JsInterop.Services
{
    public class JsInteropService
    {
        protected const string JSNamespace = "AventiusJsFunctions";

        protected IJSRuntime JSRuntime { get; set; }

        public JsInteropService(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
        }

        public async Task<DOMElement> GetElementPropertiesAsync(ElementReference elementRef)
        {
            return await JSRuntime.InvokeAsync<DOMElement>(JSNamespace + ".getElementProperties", elementRef);
        }
    }
}
