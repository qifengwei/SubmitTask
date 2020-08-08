using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitTask.Saved
{
    public class TFSNode
    {
        public String FieldName { get; set; } = "";
        public String LabelName { get; set; } = "";
        public String DefaultText { get; set; } = "";
        public List<String> DefaultOption { get; set; } = new List<string>();

        public override string ToString()
        {
            StringBuilder list = new StringBuilder();
            foreach (var s in DefaultOption) list.Append($"{s}, ");
            return $"Field={FieldName}, LabelName={LabelName}, " +
                $"DefaultText={DefaultText}, DefaultOption={list}";
        }
    }
}
