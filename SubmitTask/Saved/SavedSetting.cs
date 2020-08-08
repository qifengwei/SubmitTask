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
        public List<TFSNode> TFSNodesList { get; set; }
        public List<ExcelNode> ExcelNodesList { get; set; }
        public int Size { get => TFSNodesList.Count + ExcelNodesList.Count; }
        public int ExcelSize { get => ExcelNodesList.Count; } 
        public int TFSSize { get => TFSNodesList.Count; } 
    }
}
