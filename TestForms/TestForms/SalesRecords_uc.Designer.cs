﻿using System.Windows.Forms;

namespace TestForms
{
    partial class SalesRecords_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_salesRecords = new System.Windows.Forms.TableLayoutPanel();
            this.panel_sr_topBar = new System.Windows.Forms.TableLayoutPanel();
            this.button_refunds = new System.Windows.Forms.Button();
            this.button_popupGraph = new System.Windows.Forms.Button();
            this.button_popupPie = new System.Windows.Forms.Button();
            this.comboBox_sr_filter = new System.Windows.Forms.ComboBox();
            this.textBox_sr_search = new System.Windows.Forms.TextBox();
            this.button_csvExport = new System.Windows.Forms.Button();
            this.panel_bottomBar = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_salesRecords = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.panel_salesRecords.SuspendLayout();
            this.panel_sr_topBar.SuspendLayout();
            this.panel_bottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salesRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_salesRecords
            // 
            this.panel_salesRecords.ColumnCount = 3;
            this.panel_salesRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_salesRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_salesRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_salesRecords.Controls.Add(this.panel_sr_topBar, 1, 0);
            this.panel_salesRecords.Controls.Add(this.panel_bottomBar, 1, 2);
            this.panel_salesRecords.Controls.Add(this.dataGridView_salesRecords, 1, 1);
            this.panel_salesRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_salesRecords.Location = new System.Drawing.Point(0, 0);
            this.panel_salesRecords.Margin = new System.Windows.Forms.Padding(2);
            this.panel_salesRecords.Name = "panel_salesRecords";
            this.panel_salesRecords.RowCount = 3;
            this.panel_salesRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panel_salesRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_salesRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.panel_salesRecords.Size = new System.Drawing.Size(660, 600);
            this.panel_salesRecords.TabIndex = 21;
            // 
            // panel_sr_topBar
            // 
            this.panel_sr_topBar.AutoSize = true;
            this.panel_sr_topBar.ColumnCount = 6;
            this.panel_sr_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_sr_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_sr_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.panel_sr_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.panel_sr_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.panel_sr_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.panel_sr_topBar.Controls.Add(this.button_refunds, 4, 0);
            this.panel_sr_topBar.Controls.Add(this.button_popupGraph, 0, 0);
            this.panel_sr_topBar.Controls.Add(this.button_popupPie, 0, 0);
            this.panel_sr_topBar.Controls.Add(this.comboBox_sr_filter, 0, 0);
            this.panel_sr_topBar.Controls.Add(this.textBox_sr_search, 0, 0);
            this.panel_sr_topBar.Controls.Add(this.button_csvExport, 4, 0);
            this.panel_sr_topBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_sr_topBar.Location = new System.Drawing.Point(22, 2);
            this.panel_sr_topBar.Margin = new System.Windows.Forms.Padding(2);
            this.panel_sr_topBar.Name = "panel_sr_topBar";
            this.panel_sr_topBar.RowCount = 1;
            this.panel_sr_topBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_sr_topBar.Size = new System.Drawing.Size(616, 66);
            this.panel_sr_topBar.TabIndex = 0;
            // 
            // button_refunds
            // 
            this.button_refunds.BackColor = System.Drawing.Color.Transparent;
            this.button_refunds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_refunds.FlatAppearance.BorderSize = 0;
            this.button_refunds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_refunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refunds.ForeColor = System.Drawing.Color.Black;
            this.button_refunds.Location = new System.Drawing.Point(544, 2);
            this.button_refunds.Margin = new System.Windows.Forms.Padding(2);
            this.button_refunds.Name = "button_refunds";
            this.button_refunds.Size = new System.Drawing.Size(70, 62);
            this.button_refunds.TabIndex = 26;
            this.button_refunds.Text = "Refunds";
            this.button_refunds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_refunds.UseVisualStyleBackColor = false;
            // 
            // button_popupGraph
            // 
            this.button_popupGraph.AutoSize = true;
            this.button_popupGraph.BackColor = System.Drawing.Color.Transparent;
            this.button_popupGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_popupGraph.FlatAppearance.BorderSize = 0;
            this.button_popupGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_popupGraph.Image = global::TestForms.Properties.Resources.sales_display_graph;
            this.button_popupGraph.Location = new System.Drawing.Point(423, 2);
            this.button_popupGraph.Margin = new System.Windows.Forms.Padding(2);
            this.button_popupGraph.Name = "button_popupGraph";
            this.button_popupGraph.Size = new System.Drawing.Size(51, 62);
            this.button_popupGraph.TabIndex = 25;
            this.button_popupGraph.UseVisualStyleBackColor = false;
            // 
            // button_popupPie
            // 
            this.button_popupPie.AutoSize = true;
            this.button_popupPie.BackColor = System.Drawing.Color.Transparent;
            this.button_popupPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_popupPie.FlatAppearance.BorderSize = 0;
            this.button_popupPie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_popupPie.Image = global::TestForms.Properties.Resources.sales_display_pie;
            this.button_popupPie.Location = new System.Drawing.Point(368, 2);
            this.button_popupPie.Margin = new System.Windows.Forms.Padding(2);
            this.button_popupPie.Name = "button_popupPie";
            this.button_popupPie.Size = new System.Drawing.Size(51, 62);
            this.button_popupPie.TabIndex = 24;
            this.button_popupPie.UseVisualStyleBackColor = false;
            // 
            // comboBox_sr_filter
            // 
            this.comboBox_sr_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_sr_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_sr_filter.FormattingEnabled = true;
            this.comboBox_sr_filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_sr_filter.Location = new System.Drawing.Point(185, 21);
            this.comboBox_sr_filter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_sr_filter.Name = "comboBox_sr_filter";
            this.comboBox_sr_filter.Size = new System.Drawing.Size(179, 24);
            this.comboBox_sr_filter.TabIndex = 23;
            this.comboBox_sr_filter.Text = "Filter By";
            // 
            // textBox_sr_search
            // 
            this.textBox_sr_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sr_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_sr_search.Location = new System.Drawing.Point(2, 21);
            this.textBox_sr_search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sr_search.Name = "textBox_sr_search";
            this.textBox_sr_search.Size = new System.Drawing.Size(179, 23);
            this.textBox_sr_search.TabIndex = 22;
            this.textBox_sr_search.Text = "Search";
            // 
            // button_csvExport
            // 
            this.button_csvExport.BackColor = System.Drawing.Color.Transparent;
            this.button_csvExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_csvExport.FlatAppearance.BorderSize = 0;
            this.button_csvExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_csvExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_csvExport.ForeColor = System.Drawing.Color.Black;
            this.button_csvExport.Location = new System.Drawing.Point(478, 2);
            this.button_csvExport.Margin = new System.Windows.Forms.Padding(2);
            this.button_csvExport.Name = "button_csvExport";
            this.button_csvExport.Size = new System.Drawing.Size(62, 62);
            this.button_csvExport.TabIndex = 21;
            this.button_csvExport.Text = "CSV Export";
            this.button_csvExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_csvExport.UseVisualStyleBackColor = false;
            // 
            // panel_bottomBar
            // 
            this.panel_bottomBar.ColumnCount = 5;
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottomBar.Controls.Add(this.button_edit, 2, 0);
            this.panel_bottomBar.Controls.Add(this.button_add, 1, 0);
            this.panel_bottomBar.Controls.Add(this.button_delete, 3, 0);
            this.panel_bottomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottomBar.Location = new System.Drawing.Point(22, 516);
            this.panel_bottomBar.Margin = new System.Windows.Forms.Padding(2);
            this.panel_bottomBar.Name = "panel_bottomBar";
            this.panel_bottomBar.RowCount = 1;
            this.panel_bottomBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bottomBar.Size = new System.Drawing.Size(616, 82);
            this.panel_bottomBar.TabIndex = 1;
            // 
            // dataGridView_salesRecords
            // 
            this.dataGridView_salesRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_salesRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_salesRecords.Location = new System.Drawing.Point(22, 72);
            this.dataGridView_salesRecords.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_salesRecords.Name = "dataGridView_salesRecords";
            this.dataGridView_salesRecords.RowTemplate.Height = 24;
            this.dataGridView_salesRecords.Size = new System.Drawing.Size(616, 440);
            this.dataGridView_salesRecords.TabIndex = 2;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Transparent;
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Image = global::TestForms.Properties.Resources.delete;
            this.button_delete.Location = new System.Drawing.Point(350, 2);
            this.button_delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(76, 78);
            this.button_delete.TabIndex = 9;
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Image = global::TestForms.Properties.Resources.add;
            this.button_add.Location = new System.Drawing.Point(190, 2);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(76, 78);
            this.button_add.TabIndex = 10;
            this.button_add.UseVisualStyleBackColor = false;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Transparent;
            this.button_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Image = global::TestForms.Properties.Resources.edit;
            this.button_edit.Location = new System.Drawing.Point(270, 2);
            this.button_edit.Margin = new System.Windows.Forms.Padding(2);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(76, 78);
            this.button_edit.TabIndex = 11;
            this.button_edit.UseVisualStyleBackColor = false;
            // 
            // SalesRecords_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_salesRecords);
            this.Name = "SalesRecords_UC";
            this.Size = new System.Drawing.Size(660, 600);
            this.panel_salesRecords.ResumeLayout(false);
            this.panel_salesRecords.PerformLayout();
            this.panel_sr_topBar.ResumeLayout(false);
            this.panel_sr_topBar.PerformLayout();
            this.panel_bottomBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_salesRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_salesRecords;
        private System.Windows.Forms.TableLayoutPanel panel_sr_topBar;
        private System.Windows.Forms.Button button_refunds;
        private System.Windows.Forms.Button button_popupGraph;
        private System.Windows.Forms.Button button_popupPie;
        private System.Windows.Forms.ComboBox comboBox_sr_filter;
        private System.Windows.Forms.TextBox textBox_sr_search;
        private System.Windows.Forms.Button button_csvExport;
        private System.Windows.Forms.TableLayoutPanel panel_bottomBar;
        private System.Windows.Forms.DataGridView dataGridView_salesRecords;
        private BindingSource bindingSource1;
        private Button button_edit;
        private Button button_add;
        private Button button_delete;
    }
}