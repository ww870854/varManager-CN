using System;
using System.Windows.Forms;

namespace varManager
{
    public partial class FormStaleVars : Form
    {
        public bool removeOldVersion;
        public FormStaleVars()
        {
            InitializeComponent();
            removeOldVersion = false;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            removeOldVersion = checkBoxRemoveOldVersion.Checked;
        }
    }
}
