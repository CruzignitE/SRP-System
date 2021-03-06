﻿namespace TestForms
{
    partial class Inventory_UC
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
            this.panel_inv = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.panel_topBar = new System.Windows.Forms.TableLayoutPanel();
            this.button_logs = new System.Windows.Forms.Button();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel_bottomBar = new System.Windows.Forms.TableLayoutPanel();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel_inv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.panel_topBar.SuspendLayout();
            this.panel_bottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_inv
            // 
            this.panel_inv.ColumnCount = 3;
            this.panel_inv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_inv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_inv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_inv.Controls.Add(this.dataGridInventory, 1, 1);
            this.panel_inv.Controls.Add(this.panel_topBar, 1, 0);
            this.panel_inv.Controls.Add(this.panel_bottomBar, 1, 2);
            this.panel_inv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_inv.Location = new System.Drawing.Point(0, 0);
            this.panel_inv.Name = "panel_inv";
            this.panel_inv.RowCount = 3;
            this.panel_inv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_inv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_inv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.panel_inv.Size = new System.Drawing.Size(660, 600);
            this.panel_inv.TabIndex = 0;
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridInventory.Location = new System.Drawing.Point(22, 42);
            this.dataGridInventory.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.RowTemplate.Height = 24;
            this.dataGridInventory.Size = new System.Drawing.Size(616, 470);
            this.dataGridInventory.TabIndex = 28;
            this.dataGridInventory.SelectionChanged += new System.EventHandler(this.dataGridInventory_SelectionChanged_1);
            // 
            // panel_topBar
            // 
            this.panel_topBar.ColumnCount = 3;
            this.panel_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_topBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panel_topBar.Controls.Add(this.button_logs, 0, 0);
            this.panel_topBar.Controls.Add(this.comboBox_filter, 0, 0);
            this.panel_topBar.Controls.Add(this.textBox_search, 0, 0);
            this.panel_topBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_topBar.Location = new System.Drawing.Point(23, 3);
            this.panel_topBar.Name = "panel_topBar";
            this.panel_topBar.RowCount = 1;
            this.panel_topBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_topBar.Size = new System.Drawing.Size(614, 34);
            this.panel_topBar.TabIndex = 0;
            // 
            // button_logs
            // 
            this.button_logs.BackColor = System.Drawing.Color.Transparent;
            this.button_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_logs.FlatAppearance.BorderSize = 0;
            this.button_logs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_logs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logs.ForeColor = System.Drawing.Color.Black;
            this.button_logs.Location = new System.Drawing.Point(556, 2);
            this.button_logs.Margin = new System.Windows.Forms.Padding(2);
            this.button_logs.Name = "button_logs";
            this.button_logs.Size = new System.Drawing.Size(56, 30);
            this.button_logs.TabIndex = 32;
            this.button_logs.Text = "Logs";
            this.button_logs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_logs.UseVisualStyleBackColor = false;
            this.button_logs.Click += new System.EventHandler(this.ShowStockLog);
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox_filter.Location = new System.Drawing.Point(279, 3);
            this.comboBox_filter.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(273, 28);
            this.comboBox_filter.TabIndex = 30;
            this.comboBox_filter.Text = "Filter By";
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_search.Location = new System.Drawing.Point(2, 4);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(273, 26);
            this.textBox_search.TabIndex = 29;
            this.textBox_search.Text = "Search";
            // 
            // panel_bottomBar
            // 
            this.panel_bottomBar.ColumnCount = 4;
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_bottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_bottomBar.Controls.Add(this.button_edit, 2, 0);
            this.panel_bottomBar.Controls.Add(this.button_add, 1, 0);
            this.panel_bottomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bottomBar.Location = new System.Drawing.Point(23, 517);
            this.panel_bottomBar.Name = "panel_bottomBar";
            this.panel_bottomBar.RowCount = 1;
            this.panel_bottomBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_bottomBar.Size = new System.Drawing.Size(614, 80);
            this.panel_bottomBar.TabIndex = 1;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Transparent;
            this.button_edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_edit.FlatAppearance.BorderSize = 0;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Image = global::TestForms.Properties.Resources.edit;
            this.button_edit.Location = new System.Drawing.Point(309, 2);
            this.button_edit.Margin = new System.Windows.Forms.Padding(2);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(76, 76);
            this.button_edit.TabIndex = 26;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Image = global::TestForms.Properties.Resources.add;
            this.button_add.Location = new System.Drawing.Point(229, 2);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(76, 76);
            this.button_add.TabIndex = 25;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Inventory_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_inv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory_UC";
            this.Size = new System.Drawing.Size(660, 600);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.panel_inv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            this.panel_topBar.ResumeLayout(false);
            this.panel_topBar.PerformLayout();
            this.panel_bottomBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_inv;
        private System.Windows.Forms.TableLayoutPanel panel_topBar;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ComboBox comboBox_filter;
        private System.Windows.Forms.Button button_logs;
        private System.Windows.Forms.TableLayoutPanel panel_bottomBar;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
