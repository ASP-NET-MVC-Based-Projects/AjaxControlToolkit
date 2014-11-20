using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Web.UI;

namespace AjaxControlToolkit.HtmlEditor.ToolbarButtons {

    [ParseChildren(true)]
    [PersistChildren(false)]
    [RequiredScript(typeof(CommonToolkitScripts))]
    [ClientScriptResource("Sys.Extended.UI.HtmlEditor.ToolbarButtons.RemoveAlignment", Constants.HtmlEditorRemoveAlignmentButtonName)]
    public class RemoveAlignment : EditorToggleButton {
        protected override void OnPreRender(EventArgs e) {
            RegisterButtonImages("EdRemoveAlign");
            base.OnPreRender(e);
        }
    }

}
