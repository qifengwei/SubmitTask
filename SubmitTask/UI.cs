using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using SubmitTask.Saved.SettingUI;
using SubmitTask.Saved;

namespace SubmitTask
{
    public partial class UI
    {
        SavedSetting saved = SavedSetting.GetInstance();
        private void UI_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void bConfiguration_Click(object sender, RibbonControlEventArgs e)
        {
            Application.Run(new ConfigureUI(new TFS.TFS()));
        }
    }
}
