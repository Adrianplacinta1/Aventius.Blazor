#region Namespaces

using Microsoft.JSInterop;
using System.Threading.Tasks;

#endregion

namespace Aventius.Blazor.JsInterop
{
    public class JsInteropFunctions
    {
        private const string JSNamespace = "AventiusJsFunctions";

        protected IJSRuntime JSRuntime { get; set; }

        public JsInteropFunctions(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
        }

        public ValueTask<string> Prompt(string message)
        {
            return JSRuntime.InvokeAsync<string>(JSNamespace + ".showPrompt", message);
        }
    }
}
