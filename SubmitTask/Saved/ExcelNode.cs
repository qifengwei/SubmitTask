using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitTask.Saved
{
    public class ExcelNode
    {
        public String FieldName { get; set; } = "";
        public String LabelName { get; set; } = "";
        public Int32 ColumnNum { get; set; } = 0;
        public Boolean Check()
        {
            if (ColumnNum <= 0) return false;
            else if (FieldName == "") return false;
            else if (LabelName == "") return false;
            else return true;
        }
        public override string ToString()
        {
            return $"FieldName={FieldName}, LabelName={LabelName}, ColumnNum={ColumnNum}";
        }
    }
}
