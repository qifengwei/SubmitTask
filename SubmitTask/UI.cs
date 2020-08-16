using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using SubmitTask.Saved.SettingUI;
using SubmitTask.Saved;
using Microsoft.TeamFoundation.Client.Reporting;

namespace SubmitTask
{
    public partial class UI
    {
        private SavedSetting saved = SavedSetting.GetInstance();
        private void UI_Load(object sender, RibbonUIEventArgs e)
        {

        }
        private void bConfiguration_Click(object sender, RibbonControlEventArgs e)
        {
            System.Threading.Tasks.Task.Run(() =>
                //Application.Run(new ConfigureUI(new TFS.TFS()))
                new ConfigureUI(new TFS.TFS()).ShowDialog()
            ) ;
        }
    }
}
