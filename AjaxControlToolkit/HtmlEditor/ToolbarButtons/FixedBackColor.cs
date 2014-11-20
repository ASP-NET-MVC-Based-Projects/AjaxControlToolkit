using System;
using System.ComponentModel;
using System.Web.UI;
using System.Drawing.Design;

namespace AjaxControlToolkit.HtmlEditor.ToolbarButtons {

    [ParseChildren(true)]
    [PersistChildren(false)]
    [RequiredScript(typeof(CommonToolkitScripts))]
    [ClientScriptResource("Sys.Extended.UI.HtmlEditor.ToolbarButtons.FixedBackColor", Constants.HtmlEditorFixedBackColorButtonName)]
    public class FixedBackColor : FixedColorButton {
        protected override void OnInit(EventArgs e) {
            base.OnInit(e);
            MethodButton = new MethodButton();
            MethodButton.CssClass = String.Empty;
            DefaultColor = "#FFFF00";
        }

        protected override void OnPreRender(EventArgs e) {
            MethodButton.InternalRegisterButtonImages("EdBackColor");
            base.OnPreRender(e);
        }
    }

}
