﻿namespace SubmitTask.Saved.SettingUI
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
            this.components = new System.ComponentModel.Container();
            this.lbUnselectedFields = new System.Windows.Forms.ListBox();
            this.bReset = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.lExcel = new System.Windows.Forms.Label();
            this.lTFS = new System.Windows.Forms.Label();
            this.bAddExcel = new System.Windows.Forms.Button();
            this.bRemoveExcel = new System.Windows.Forms.Button();
            this.bAddTFS = new System.Windows.Forms.Button();
            this.bRemoveTFS = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.excelNodesListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTFS = new System.Windows.Forms.DataGridView();
            this.fieldNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tFSNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.savedSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelNodesListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFSNodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savedSettingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUnselectedFields
            // 
            this.lbUnselectedFields.FormattingEnabled = true;
            this.lbUnselectedFields.ItemHeight = 18;
            this.lbUnselectedFields.Location = new System.Drawing.Point(12, 12);
            this.lbUnselectedFields.Name = "lbUnselectedFields";
            this.lbUnselectedFields.Size = new System.Drawing.Size(304, 652);
            this.lbUnselectedFields.Sorted = true;
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
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
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
            this.bAddExcel.BackgroundImage = global::SubmitTask.Properties.Resources.Right;
            this.bAddExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddExcel.Location = new System.Drawing.Point(320, 117);
            this.bAddExcel.Name = "bAddExcel";
            this.bAddExcel.Size = new System.Drawing.Size(63, 35);
            this.bAddExcel.TabIndex = 6;
            this.bAddExcel.UseVisualStyleBackColor = true;
            this.bAddExcel.Click += new System.EventHandler(this.bAddExcel_Click);
            // 
            // bRemoveExcel
            // 
            this.bRemoveExcel.BackgroundImage = global::SubmitTask.Properties.Resources.Left;
            this.bRemoveExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRemoveExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRemoveExcel.Location = new System.Drawing.Point(320, 172);
            this.bRemoveExcel.Name = "bRemoveExcel";
            this.bRemoveExcel.Size = new System.Drawing.Size(63, 35);
            this.bRemoveExcel.TabIndex = 6;
            this.bRemoveExcel.UseVisualStyleBackColor = true;
            this.bRemoveExcel.Click += new System.EventHandler(this.bRemoveExcel_Click);
            // 
            // bAddTFS
            // 
            this.bAddTFS.BackgroundImage = global::SubmitTask.Properties.Resources.Right;
            this.bAddTFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAddTFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddTFS.Location = new System.Drawing.Point(322, 482);
            this.bAddTFS.Name = "bAddTFS";
            this.bAddTFS.Size = new System.Drawing.Size(63, 35);
            this.bAddTFS.TabIndex = 6;
            this.bAddTFS.UseVisualStyleBackColor = true;
            this.bAddTFS.Click += new System.EventHandler(this.bAddTFS_Click);
            // 
            // bRemoveTFS
            // 
            this.bRemoveTFS.BackgroundImage = global::SubmitTask.Properties.Resources.Left;
            this.bRemoveTFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRemoveTFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRemoveTFS.Location = new System.Drawing.Point(322, 537);
            this.bRemoveTFS.Name = "bRemoveTFS";
            this.bRemoveTFS.Size = new System.Drawing.Size(63, 35);
            this.bRemoveTFS.TabIndex = 6;
            this.bRemoveTFS.UseVisualStyleBackColor = true;
            this.bRemoveTFS.Click += new System.EventHandler(this.bRemoveTFS_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(331, 692);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(124, 40);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "取消";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // dgvExcel
            // 
            this.dgvExcel.AutoGenerateColumns = false;
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldNameDataGridViewTextBoxColumn,
            this.labelNameDataGridViewTextBoxColumn,
            this.columnNumDataGridViewTextBoxColumn,
            this.requiredDataGridViewCheckBoxColumn});
            this.dgvExcel.DataSource = this.excelNodesListBindingSource;
            this.dgvExcel.Location = new System.Drawing.Point(388, 43);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.RowHeadersWidth = 30;
            this.dgvExcel.RowTemplate.Height = 30;
            this.dgvExcel.Size = new System.Drawing.Size(547, 306);
            this.dgvExcel.TabIndex = 8;
            // 
            // excelNodesListBindingSource
            // 
            this.excelNodesListBindingSource.DataMember = "ExcelNodesList";
            this.excelNodesListBindingSource.DataSource = this.savedSettingBindingSource;
            // 
            // dgvTFS
            // 
            this.dgvTFS.AutoGenerateColumns = false;
            this.dgvTFS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTFS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldNameDataGridViewTextBoxColumn1,
            this.labelNameDataGridViewTextBoxColumn1,
            this.defaultTextDataGridViewTextBoxColumn,
            this.requiredDataGridViewCheckBoxColumn1});
            this.dgvTFS.DataSource = this.tFSNodeBindingSource;
            this.dgvTFS.Location = new System.Drawing.Point(388, 374);
            this.dgvTFS.Name = "dgvTFS";
            this.dgvTFS.RowHeadersWidth = 30;
            this.dgvTFS.RowTemplate.Height = 30;
            this.dgvTFS.Size = new System.Drawing.Size(547, 290);
            this.dgvTFS.TabIndex = 9;
            // 
            // fieldNameDataGridViewTextBoxColumn1
            // 
            this.fieldNameDataGridViewTextBoxColumn1.DataPropertyName = "FieldName";
            this.fieldNameDataGridViewTextBoxColumn1.HeaderText = "字段名";
            this.fieldNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.fieldNameDataGridViewTextBoxColumn1.Name = "fieldNameDataGridViewTextBoxColumn1";
            this.fieldNameDataGridViewTextBoxColumn1.ToolTipText = "TFS上对应字段的名字，唯一";
            this.fieldNameDataGridViewTextBoxColumn1.Width = 156;
            // 
            // labelNameDataGridViewTextBoxColumn1
            // 
            this.labelNameDataGridViewTextBoxColumn1.DataPropertyName = "LabelName";
            this.labelNameDataGridViewTextBoxColumn1.HeaderText = "显示名";
            this.labelNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.labelNameDataGridViewTextBoxColumn1.Name = "labelNameDataGridViewTextBoxColumn1";
            this.labelNameDataGridViewTextBoxColumn1.ToolTipText = "在VSTO应用中显示给用户的名字";
            this.labelNameDataGridViewTextBoxColumn1.Width = 156;
            // 
            // defaultTextDataGridViewTextBoxColumn
            // 
            this.defaultTextDataGridViewTextBoxColumn.DataPropertyName = "DefaultText";
            this.defaultTextDataGridViewTextBoxColumn.HeaderText = "默认数据";
            this.defaultTextDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.defaultTextDataGridViewTextBoxColumn.Name = "defaultTextDataGridViewTextBoxColumn";
            this.defaultTextDataGridViewTextBoxColumn.ToolTipText = "默认选中的数据";
            this.defaultTextDataGridViewTextBoxColumn.Width = 155;
            // 
            // requiredDataGridViewCheckBoxColumn1
            // 
            this.requiredDataGridViewCheckBoxColumn1.DataPropertyName = "Required";
            this.requiredDataGridViewCheckBoxColumn1.HeaderText = "必填";
            this.requiredDataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.requiredDataGridViewCheckBoxColumn1.Name = "requiredDataGridViewCheckBoxColumn1";
            this.requiredDataGridViewCheckBoxColumn1.Width = 50;
            // 
            // tFSNodeBindingSource
            // 
            this.tFSNodeBindingSource.DataSource = typeof(SubmitTask.Saved.TFSNode);
            // 
            // fieldNameDataGridViewTextBoxColumn
            // 
            this.fieldNameDataGridViewTextBoxColumn.DataPropertyName = "FieldName";
            this.fieldNameDataGridViewTextBoxColumn.HeaderText = "字段名";
            this.fieldNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fieldNameDataGridViewTextBoxColumn.Name = "fieldNameDataGridViewTextBoxColumn";
            this.fieldNameDataGridViewTextBoxColumn.Width = 205;
            // 
            // labelNameDataGridViewTextBoxColumn
            // 
            this.labelNameDataGridViewTextBoxColumn.DataPropertyName = "LabelName";
            this.labelNameDataGridViewTextBoxColumn.HeaderText = "显示名";
            this.labelNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.labelNameDataGridViewTextBoxColumn.Name = "labelNameDataGridViewTextBoxColumn";
            this.labelNameDataGridViewTextBoxColumn.Width = 205;
            // 
            // columnNumDataGridViewTextBoxColumn
            // 
            this.columnNumDataGridViewTextBoxColumn.DataPropertyName = "ColumnNum";
            this.columnNumDataGridViewTextBoxColumn.HeaderText = "列";
            this.columnNumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.columnNumDataGridViewTextBoxColumn.Name = "columnNumDataGridViewTextBoxColumn";
            this.columnNumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnNumDataGridViewTextBoxColumn.Width = 50;
            // 
            // requiredDataGridViewCheckBoxColumn
            // 
            this.requiredDataGridViewCheckBoxColumn.DataPropertyName = "Required";
            this.requiredDataGridViewCheckBoxColumn.HeaderText = "必填";
            this.requiredDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.requiredDataGridViewCheckBoxColumn.Name = "requiredDataGridViewCheckBoxColumn";
            this.requiredDataGridViewCheckBoxColumn.Width = 50;
            // 
            // savedSettingBindingSource
            // 
            this.savedSettingBindingSource.DataSource = typeof(SubmitTask.Saved.SavedSetting);
            // 
            // ConfigureUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 744);
            this.Controls.Add(this.dgvTFS);
            this.Controls.Add(this.dgvExcel);
            this.Controls.Add(this.bRemoveTFS);
            this.Controls.Add(this.bAddTFS);
            this.Controls.Add(this.bRemoveExcel);
            this.Controls.Add(this.bAddExcel);
            this.Controls.Add(this.lTFS);
            this.Controls.Add(this.lExcel);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.lbUnselectedFields);
            this.Name = "ConfigureUI";
            this.Text = "ConfigureUI";
            this.Load += new System.EventHandler(this.ConfigureUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelNodesListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTFS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFSNodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savedSettingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUnselectedFields;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Label lExcel;
        private System.Windows.Forms.Label lTFS;
        private System.Windows.Forms.Button bAddExcel;
        private System.Windows.Forms.Button bRemoveExcel;
        private System.Windows.Forms.Button bAddTFS;
        private System.Windows.Forms.Button bRemoveTFS;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.BindingSource excelNodesListBindingSource;
        private System.Windows.Forms.BindingSource savedSettingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn requiredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dgvTFS;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn requiredDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource tFSNodeBindingSource;
    }
}