using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace EasyBackup
{
    public class ContainerControlDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            if (!component.Site.DesignMode)
            {
                return;
            }

            foreach (Control control in this.Control.Controls)
            {
                this.EnableDesignMode(control);
            }
        }

        private bool EnableDesignMode(Control control)
        {
            return this.EnableDesignMode(control, control.Name);
        }
    }
}