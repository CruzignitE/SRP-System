namespace TestForms
{
    partial class ProductsList
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProductGridTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productBinding = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(587, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 28);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "Filter By";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(320, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Search";
            // 
            // ProductGridTable
            // 
            this.ProductGridTable.AccessibleName = "";
            this.ProductGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridTable.Location = new System.Drawing.Point(183, 69);
            this.ProductGridTable.Name = "ProductGridTable";
            this.ProductGridTable.RowTemplate.Height = 24;
            this.ProductGridTable.Size = new System.Drawing.Size(848, 521);
            this.ProductGridTable.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "SRP System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 691);
            this.panel1.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::TestForms.Properties.Resources.prediction;
            this.button3.Location = new System.Drawing.Point(0, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 129);
            this.button3.TabIndex = 20;
            this.button3.Text = "Sales Predictions";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(96)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::TestForms.Properties.Resources.inventory;
            this.button2.Location = new System.Drawing.Point(0, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 129);
            this.button2.TabIndex = 19;
            this.button2.Text = "Inventory";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::TestForms.Properties.Resources.products;
            this.button5.Location = new System.Drawing.Point(0, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 129);
            this.button5.TabIndex = 18;
            this.button5.Text = "Products List";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Image = global::TestForms.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(671, 607);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 61);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = global::TestForms.Properties.Resources.edit;
            this.editButton.Location = new System.Drawing.Point(556, 607);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(67, 61);
            this.editButton.TabIndex = 21;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::TestForms.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(436, 607);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(67, 61);
            this.addButton.TabIndex = 20;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::TestForms.Properties.Resources.sales_records;
            this.button1.Location = new System.Drawing.Point(0, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 129);
            this.button1.TabIndex = 19;
            this.button1.Text = "Sales Records";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 691);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ProductGridTable);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductsList";
            this.Text = "ProductsList";
            this.Load += new System.EventHandler(this.ProductsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridTable)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView ProductGridTable;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource productBinding;
    }
}