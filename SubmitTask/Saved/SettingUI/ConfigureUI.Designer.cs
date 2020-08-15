namespace SubmitTask.Saved.SettingUI
{
    partial class ConfigureUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUnselectedFields = new System.Windows.Forms.ListBox();
            this.bReset = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.lvExcel = new System.Windows.Forms.ListView();
            this.lvTFS = new System.Windows.Forms.ListView();
            this.lExcel = new System.Windows.Forms.Label();
            this.lTFS = new System.Windows.Forms.Label();
            this.bAddExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUnselectedFields
            // 
            this.lbUnselectedFields.FormattingEnabled = true;
            this.lbUnselectedFields.ItemHeight = 18;
            this.lbUnselectedFields.Location = new System.Drawing.Point(12, 12);
            this.lbUnselectedFields.Name = "lbUnselectedFields";
            this.lbUnselectedFields.Size = new System.Drawing.Size(304, 652);
            this.lbUnselectedFields.TabIndex = 0;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(12, 692);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(124, 40);
            this.bReset.TabIndex = 1;
            this.bReset.Text = "重置";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(174, 692);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(124, 40);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "应用";
            this.bApply.UseVisualStyleBackColor = true;
            // 
            // lvExcel
            // 
            this.lvExcel.Location = new System.Drawing.Point(388, 51);
            this.lvExcel.Name = "lvExcel";
            this.lvExcel.Size = new System.Drawing.Size(550, 268);
            this.lvExcel.TabIndex = 2;
            this.lvExcel.UseCompatibleStateImageBehavior = false;
            // 
            // lvTFS
            // 
            this.lvTFS.Location = new System.Drawing.Point(388, 376);
            this.lvTFS.Name = "lvTFS";
            this.lvTFS.Size = new System.Drawing.Size(550, 288);
            this.lvTFS.TabIndex = 3;
            this.lvTFS.UseCompatibleStateImageBehavior = false;
            // 
            // lExcel
            // 
            this.lExcel.AutoSize = true;
            this.lExcel.Location = new System.Drawing.Point(385, 21);
            this.lExcel.Name = "lExcel";
            this.lExcel.Size = new System.Drawing.Size(143, 18);
            this.lExcel.TabIndex = 4;
            this.lExcel.Text = "从Excel获取数据";
            // 
            // lTFS
            // 
            this.lTFS.AutoSize = true;
            this.lTFS.Location = new System.Drawing.Point(388, 352);
            this.lTFS.Name = "lTFS";
            this.lTFS.Size = new System.Drawing.Size(125, 18);
            this.lTFS.TabIndex = 5;
            this.lTFS.Text = "从TFS获取数据";
            // 
            // bAddExcel
            // 
            this.bAddExcel.Image = global::SubmitTask.Properties.Resources.Right;
            this.bAddExcel.Location = new System.Drawing.Point(323, 112);
            this.bAddExcel.Name = "bAddExcel";
            this.bAddExcel.Size = new System.Drawing.Size(75, 54);
            this.bAddExcel.TabIndex = 6;
            this.bAddExcel.UseVisualStyleBackColor = true;
            // 
            // ConfigureUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 744);
            this.Controls.Add(this.bAddExcel);
            this.Controls.Add(this.lTFS);
            this.Controls.Add(this.lExcel);
            this.Controls.Add(this.lvTFS);
            this.Controls.Add(this.lvExcel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.lbUnselectedFields);
            this.Name = "ConfigureUI";
            this.Text = "ConfigureUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUnselectedFields;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.ListView lvExcel;
        private System.Windows.Forms.ListView lvTFS;
        private System.Windows.Forms.Label lExcel;
        private System.Windows.Forms.Label lTFS;
        private System.Windows.Forms.Button bAddExcel;
    }
}