using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitTask.Saved
{
    public class SavedSetting
    {
        public List<TFSNode> TFSNodesList { get; set; } = new List<TFSNode>();
        public List<ExcelNode> ExcelNodesList { get; set; } = new List<ExcelNode>();

        public int Size { get => TFSNodesList.Count + ExcelNodesList.Count; }

        public int ExcelSize { get => ExcelNodesList.Count; } 
        public int TFSSize { get => TFSNodesList.Count; }

        private static SavedSetting instance = new SavedSetting();

        private SavedSetting() { }

        public static SavedSetting GetInstance() => instance;

        public Boolean AddTFSNode(TFSNode node)
        {
            if (node.Check())
            {
                TFSNodesList.Add(node);
                return true;
            }
            return false;           
        }

        public Boolean AddExcelNode(ExcelNode node)
        {
            if (node.Check())
            {
                ExcelNodesList.Add(node);
                return true;
            }
            return false;
        }

        public void ClearExcelNodesList()
        {
            ExcelNodesList.Clear();
        }

        public void ClearTFSNodesList()
        {
            TFSNodesList.Clear();
        }
        public void Clear()
        {
            TFSNodesList.Clear();
            ExcelNodesList.Clear();
        }

        public Boolean AddExcelNodes(List<ExcelNode> nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.Check()) return false;
            }
            foreach (var node in nodes) ExcelNodesList.Add(node);
            return true;
        }


        public Boolean AddTFSNodes(List<TFSNode> nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.Check()) return false;
            }
            foreach (var node in nodes) TFSNodesList.Add(node);
            return true;
        }
    }
}
