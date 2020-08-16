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
        private SavedSetting saved = SavedSetting.GetInstance();
        public ConfigureUI()
        {
            InitializeComponent();
        }

        public ConfigureUI(TFS.TFS tfs)
        {
            InitializeComponent();
            saved.Clear();
            this.ControlBox = false;
            foreach (var item in tfs.GetFieldDefinitionsText("Task"))
            {
                lbUnselectedFields.Items.Add(item);
            }
            dgvExcel.DataSource = saved.ExcelNodesList;
        }

        private void bReset_Click(object sender, EventArgs e)
        {

        }

        private void bAddExcel_Click(object sender, EventArgs e)
        {
            if (lbUnselectedFields.SelectedItem != null)
            {
                saved.AddExcelNode(new ExcelNode()
                {
                    FieldName = (string)lbUnselectedFields.SelectedItem,
                    LabelName = (string)lbUnselectedFields.SelectedItem,
                    ColumnNum = "A",
                    Required = true,
                }) ;
                //dgvExcel.DataSource =null;
                //dgvExcel.DataSource = saved.ExcelNodesList;
                CurrencyManager cm = (CurrencyManager)dgvExcel.BindingContext[saved.ExcelNodesList];
                if (cm != null) cm.Refresh();
                lbUnselectedFields.Items.Remove(lbUnselectedFields.SelectedItem);
            }
        }

        private void bRemoveExcel_Click(object sender, EventArgs e)
        {
            if (dgvExcel.SelectedRows != null)
            {
                foreach (DataGridViewRow selectedrow in dgvExcel.SelectedRows)
                {
                    saved.ExcelNodesList.RemoveAll(node => node.FieldName == selectedrow.Cells[1].Value.ToString());
                    CurrencyManager cm = (CurrencyManager)dgvExcel.BindingContext[saved.ExcelNodesList];
                    if (cm != null) cm.Refresh();
                    //lbUnselectedFields.Items.Add(dgvExcel.SelectedRows[0].Cells[1].Value.ToString());
                }
            }
        }

        private void ConfigureUI_Load(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void excelNodesListBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
