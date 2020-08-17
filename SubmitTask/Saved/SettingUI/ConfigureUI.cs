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
        private TFS.TFS tfs;
        public ConfigureUI()
        {
            InitializeComponent();
        }

        public ConfigureUI(TFS.TFS tfs)
        {
            this.tfs = tfs;
            InitializeComponent();
            this.ControlBox = false;
            foreach (var item in tfs.GetFieldDefinitionsText("Task"))
            {
                if (saved.ExcelNodesList.Exists(
                    node => node.FieldName == item)) continue;
                if (saved.TFSNodesList.Exists(
                    node => node.FieldName == item)) continue;
                lbUnselectedFields.Items.Add(item);
            }
            dgvExcel.DataSource = saved.ExcelNodesList;
            dgvTFS.DataSource = saved.TFSNodesList;

            dgvExcel.CellValidating += DgvExcel_CellValidating;
            dgvTFS.CellValidating += DgvTFS_CellValidating;
        }

        private void DgvTFS_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void DgvExcel_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void bReset_Click(object sender, EventArgs e)
        {
            saved.Clear();
            CurrencyManager cm = (CurrencyManager)dgvExcel.BindingContext[saved.ExcelNodesList];
            if (cm != null) cm.Refresh();
            cm = (CurrencyManager)dgvTFS.BindingContext[saved.TFSNodesList];
            if (cm != null) cm.Refresh();
            foreach (var item in tfs.GetFieldDefinitionsText("Task"))
            {
                lbUnselectedFields.Items.Add(item);
            }
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
                List<String> removeds = new List<string>();
                foreach (DataGridViewRow selectedrow in dgvExcel.SelectedRows)
                {
                    removeds.Add(selectedrow.Cells[0].Value.ToString());
                }
                foreach (String removed in removeds)
                {
                    saved.ExcelNodesList.RemoveAll(node => node.FieldName == removed);
                    lbUnselectedFields.Items.Add(removed);
                }
                CurrencyManager cm = (CurrencyManager)dgvExcel.BindingContext[saved.ExcelNodesList];
                if (cm != null) cm.Refresh();
            }
        }

        private void bAddTFS_Click(object sender, EventArgs e)
        {
            if (lbUnselectedFields.SelectedItem != null)
            {
                saved.AddTFSNode(new TFSNode()
                {
                    FieldName = (string)lbUnselectedFields.SelectedItem,
                    LabelName = (string)lbUnselectedFields.SelectedItem,
                    DefaultOption = new List<String>(),
                    Required = true,
                });
                CurrencyManager cm = (CurrencyManager)dgvTFS.BindingContext[saved.TFSNodesList];
                if (cm != null) cm.Refresh();
                lbUnselectedFields.Items.Remove(lbUnselectedFields.SelectedItem);
            }
        }

        private void bRemoveTFS_Click(object sender, EventArgs e)
        {
            if (dgvTFS.SelectedRows != null)
            {
                List<String> removeds = new List<string>();
                foreach (DataGridViewRow selectedrow in dgvTFS.SelectedRows)
                {
                    removeds.Add(selectedrow.Cells[0].Value.ToString());
                }
                foreach (String removed in removeds)
                {
                    saved.TFSNodesList.RemoveAll(node => node.FieldName == removed);
                    lbUnselectedFields.Items.Add(removed);
                }
                CurrencyManager cm = (CurrencyManager)dgvTFS.BindingContext[saved.TFSNodesList];
                if (cm != null) cm.Refresh();
            }
        }

        private void ConfigureUI_Load(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            UserPath.DeserializeSaved();
            Application.ExitThread();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            //SerializerSaved(Saved.UserPath.savedpath);
            UserPath.SerializerSaved();
            Application.ExitThread();
        }

        private void SerializerSaved(String savedPath)
        {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Saved.SavedSetting));
            //var path = Saved.UserPath.savedpath + "//SerializationOverview.xml";
            using (System.IO.FileStream file = new System.IO.FileStream(savedPath, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
            {
                writer.Serialize(file, saved);
            }
        }

        private void DeserializeSaved(String savedPath)
        {
            System.Xml.Serialization.XmlSerializer reader =
            new System.Xml.Serialization.XmlSerializer(typeof(Saved.SavedSetting));
            //var path = Saved.UserPath.savedpath + "//SerializationOverview.xml";
            using (System.IO.FileStream file = new System.IO.FileStream(savedPath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite))
            {
                saved = (Saved.SavedSetting)reader.Deserialize(file);
            }
        }

        private void excelNodesListBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


    }
}
