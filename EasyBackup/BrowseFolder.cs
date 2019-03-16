using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EasyBackup
{
    //[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    [Designer(typeof(ContainerControlDesigner))]
    public partial class BrowseFolder : UserControl
    {
        private const string CATEGORY_CONTROLS = "Controls";

        private static readonly object EventPathChangedKey = new object();

        public BrowseFolder()
        {
            this.InitializeComponent();
        }

        [Browsable(true)]
        [Category(CATEGORY_CONTROLS)]
        [Description("The label that describes the folder's meaning in the context it's in.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Label Label => this.Lbl;

        [Browsable(true)]
        [Category(CATEGORY_CONTROLS)]
        [Description("The text box that displays or lets the user edit the full path of the folder.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TextBox TextBox_DirectoryFullPath => this.TxtBox_DirectoryFullPath;

        [Browsable(true)]
        [Category(CATEGORY_CONTROLS)]
        [Description("The button that displays the folder browse dialog when clicked.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Button Button_BrowseDirectory => this.Btn_BrowseDirectory;

        [Browsable(true)]
        [Category(CATEGORY_CONTROLS)]
        [Description("The folder browse dialog.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public FolderBrowserDialog FolderBrowserDialog => this.Fbd;

        [Browsable(true)]
        [Category("Property Changed")]
        [Description("Raised when the selected path changes")]
        public event EventHandler<EventArgs> PathChanged
        {
            add
            {
                this.Events.AddHandler(EventPathChangedKey, value);
            }
            remove
            {
                this.Events.RemoveHandler(EventPathChangedKey, value);
            }
        }

        [Browsable(true)]
        public string SelectedPath
        {
            get
            {
                return this.TextBox_DirectoryFullPath.Text;
            }
            set
            {
                this.FolderBrowserDialog.SelectedPath = value;
                this.TextBox_DirectoryFullPath.Text = value;
                this.InvokePathChanged();
            }
        }

        private void Btn_BrowseDirectory_Click(object sender, EventArgs e)
        {
            if (this.FolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.TextBox_DirectoryFullPath.Text = this.FolderBrowserDialog.SelectedPath;
                this.InvokePathChanged();
            }
        }

        private void TxtBox_DirectoryFullPath_TextChanged(object sender, EventArgs e)
        {
            this.InvokePathChanged();
        }

        protected void InvokePathChanged()
        {
            ((EventHandler<EventArgs>)this.Events[EventPathChangedKey])?.Invoke(this, EventArgs.Empty);
        }
    }
}