// MIT License.

using System.Web.UI;
using Compiler.Dynamic.Tests.ReferenceAssembly;

namespace SystemWebUISample.Base
{

    public partial class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {
            var c = new Class1();
            c.BasePageTitle = "Hello World";
            this.BasePageTitle = c.BasePageTitle;
        }
        public string BasePageTitle { get; set; }
    }
}
