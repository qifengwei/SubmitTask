using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmitTask.Saved
{
    public class TFSNode
    {
        /// <summary>
        /// TFS字段名
        /// </summary>
        public String FieldName { get; set; } = "";
        /// <summary>
        /// VSTO 控件显示名
        /// </summary>
        public String LabelName { get; set; } = "";
        /// <summary>
        /// 默认选中项
        /// </summary>
        public String DefaultText { get; set; } = "";
        /// <summary>
        /// 默认下拉菜单可选项
        /// </summary>
        public List<String> DefaultOption { get; set; } = new List<string>();
        /// <summary>
        /// 检查TFSNode是否有效
        /// </summary>
        /// <returns>有效返回True</returns>
        public Boolean Check()
        {
            if (FieldName == "") return false;
            else if (LabelName == "") return false;
            else return true;
        }

        public override string ToString()
        {
            StringBuilder list = new StringBuilder();
            foreach (var s in DefaultOption) list.Append($"{s}, ");
            return $"Field={FieldName}, LabelName={LabelName}, " +
                $"DefaultText={DefaultText}, DefaultOption={list}";
        }
    }
}
