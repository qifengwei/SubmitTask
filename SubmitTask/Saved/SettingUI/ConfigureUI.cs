using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubmitTask.TFS;

namespace SubmitTask.Saved.SettingUI
{
    public partial class ConfigureUI : Form
    {
        public ConfigureUI()
        {
            InitializeComponent();
        }

        public ConfigureUI(TFS.TFS tfs)
        {
            InitializeComponent();
            foreach (var item in tfs.GetFieldDefinitionsText("Task"))
            {
                lbUnselectedFields.Items.Add(item);
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {

        }
    }
}
