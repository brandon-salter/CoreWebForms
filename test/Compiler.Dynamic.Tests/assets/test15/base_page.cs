// MIT License.

using System.Web.UI;

namespace SystemWebUISample.Base
{

    public partial class BasePage : System.Web.UI.Page
    {
        public BasePage()
        {
            var c = new ClassToReference();
            this.BasePageTitle = c.BasePageTitle;
        }
        public string BasePageTitle { get; set; } 
    }
}
