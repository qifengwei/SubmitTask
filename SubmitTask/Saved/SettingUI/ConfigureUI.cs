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
            lvExcel.View = View.Details;
            lvExcel.FullRowSelect = true;
            lvExcel.LabelEdit = true;
            //ColumnHeader[] header = {
            //    new ColumnHeader("字段"),
            //    new ColumnHeader("显示"),
            //    new ColumnHeader("表列"),
            //    new ColumnHeader("必填"),
            //};
            //lvExcel.Columns.AddRange(header);
            lvExcel.Columns.Add("字段名", 220);
            lvExcel.Columns.Add("显示值", 220);
            lvExcel.Columns.Add("表列", 57);
            lvExcel.Columns.Add("必填", 50);
        }

        private void bReset_Click(object sender, EventArgs e)
        {

        }

        private void bAddExcel_Click(object sender, EventArgs e)
        {
            if (lbUnselectedFields.SelectedItem != null)
            {
                ListViewItem item = new ListViewItem((String)lbUnselectedFields.SelectedItem);
                item.SubItems.Add((String)lbUnselectedFields.SelectedItem);
                item.SubItems.Add("1");
                lvExcel.Items.Add(item);
                //item.SubItems.Add();
                saved.AddExcelNode(new ExcelNode()
                {
                    FieldName = (String)lbUnselectedFields.SelectedItem,
                    LabelName = (String)lbUnselectedFields.SelectedItem,
                    ColumnNum = 1,
                    Required = false
                });
                lbUnselectedFields.Items.Remove(lbUnselectedFields.SelectedItem);               
            }
        }

        private void bRemoveExcel_Click(object sender, EventArgs e)
        {

        }

        private void ConfigureUI_Load(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
