using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Web.UI;

namespace AjaxControlToolkit.HtmlEditor.ToolbarButtons {

    [ParseChildren(true)]
    [PersistChildren(false)]
    [RequiredScript(typeof(CommonToolkitScripts))]
    [ClientScriptResource("Sys.Extended.UI.HtmlEditor.ToolbarButtons.Ltr", Constants.HtmlEditorLtrButtonName)]
    public class Ltr : EditorToggleButton {
        protected override void OnPreRender(EventArgs e) {
            RegisterButtonImages("EdFormatLtr");
            base.OnPreRender(e);
        }
    }

}
