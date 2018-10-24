namespace TestForms
{
    partial class AddEditSalesRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtBoxProductID = new System.Windows.Forms.TextBox();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxProductQty = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSubmitSalesRecord = new System.Windows.Forms.Button();
            this.btnBrowseProduct = new System.Windows.Forms.Button();
            this.dataGridSalesProduct = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.txtBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxProductQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grand Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sale ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Qty";
            // 
            // txtBoxGrandTotal
            // 
            this.txtBoxGrandTotal.Location = new System.Drawing.Point(604, 382);
            this.txtBoxGrandTotal.Name = "txtBoxGrandTotal";
            this.txtBoxGrandTotal.ReadOnly = true;
            this.txtBoxGrandTotal.Size = new System.Drawing.Size(100, 21);
            this.txtBoxGrandTotal.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(604, 411);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(262, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(146, 21);
            this.textBox5.TabIndex = 15;
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.Location = new System.Drawing.Point(155, 84);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.ReadOnly = true;
            this.txtBoxProductID.Size = new System.Drawing.Size(125, 21);
            this.txtBoxProductID.TabIndex = 0;
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(286, 84);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.ReadOnly = true;
            this.txtBoxProductName.Size = new System.Drawing.Size(245, 21);
            this.txtBoxProductName.TabIndex = 1;
            // 
            // txtBoxProductQty
            // 
            this.txtBoxProductQty.Location = new System.Drawing.Point(537, 84);
            this.txtBoxProductQty.Name = "txtBoxProductQty";
            this.txtBoxProductQty.Size = new System.Drawing.Size(120, 21);
            this.txtBoxProductQty.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(486, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Image = global::TestForms.Properties.Resources.add;
            this.btnAddProduct.Location = new System.Drawing.Point(710, 84);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(50, 46);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::TestForms.Properties.Resources.delete;
            this.button3.Location = new System.Drawing.Point(707, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 46);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSubmitSalesRecord
            // 
            this.btnSubmitSalesRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitSalesRecord.FlatAppearance.BorderSize = 0;
            this.btnSubmitSalesRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitSalesRecord.Image = global::TestForms.Properties.Resources.confirm;
            this.btnSubmitSalesRecord.Location = new System.Drawing.Point(651, 452);
            this.btnSubmitSalesRecord.Name = "btnSubmitSalesRecord";
            this.btnSubmitSalesRecord.Size = new System.Drawing.Size(50, 46);
            this.btnSubmitSalesRecord.TabIndex = 0;
            this.btnSubmitSalesRecord.UseVisualStyleBackColor = false;
            this.btnSubmitSalesRecord.Click += new System.EventHandler(this.btnSubmitSalesRecord_Click);
            // 
            // btnBrowseProduct
            // 
            this.btnBrowseProduct.Location = new System.Drawing.Point(22, 84);
            this.btnBrowseProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowseProduct.Name = "btnBrowseProduct";
            this.btnBrowseProduct.Size = new System.Drawing.Size(104, 22);
            this.btnBrowseProduct.TabIndex = 18;
            this.btnBrowseProduct.Text = "browse product";
            this.btnBrowseProduct.UseVisualStyleBackColor = true;
            this.btnBrowseProduct.Click += new System.EventHandler(this.btnBrowseProduct_Click);
            // 
            // dataGridSalesProduct
            // 
            this.dataGridSalesProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalesProduct.Location = new System.Drawing.Point(128, 156);
            this.dataGridSalesProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridSalesProduct.Name = "dataGridSalesProduct";
            this.dataGridSalesProduct.RowTemplate.Height = 24;
            this.dataGridSalesProduct.Size = new System.Drawing.Size(575, 212);
            this.dataGridSalesProduct.TabIndex = 19;
            this.dataGridSalesProduct.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridSalesProduct_RowsRemoved);
            this.dataGridSalesProduct.SelectionChanged += new System.EventHandler(this.dataGridSalesProduct_SelectionChanged);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::TestForms.Properties.Resources.delete;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(663, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 21);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtBoxProductPrice
            // 
            this.txtBoxProductPrice.Location = new System.Drawing.Point(155, 127);
            this.txtBoxProductPrice.Name = "txtBoxProductPrice";
            this.txtBoxProductPrice.ReadOnly = true;
            this.txtBoxProductPrice.Size = new System.Drawing.Size(125, 21);
            this.txtBoxProductPrice.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Product Price";
            // 
            // AddEditSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxProductPrice);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtBoxProductQty);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.txtBoxProductID);
            this.Controls.Add(this.dataGridSalesProduct);
            this.Controls.Add(this.btnBrowseProduct);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtBoxGrandTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSubmitSalesRecord);
            this.Name = "AddEditSalesRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Check-out";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditSalesRecord_FormClosing);
            this.Load += new System.EventHandler(this.AddEditSalesRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxProductQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitSalesRecord;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxGrandTotal;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtBoxProductID;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.NumericUpDown txtBoxProductQty;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBrowseProduct;
        private System.Windows.Forms.DataGridView dataGridSalesProduct;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBoxProductPrice;
        private System.Windows.Forms.Label label4;
    }
}