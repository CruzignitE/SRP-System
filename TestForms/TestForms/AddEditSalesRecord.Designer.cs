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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.txtBoxSalesID = new System.Windows.Forms.TextBox();
            this.txtBoxProductID = new System.Windows.Forms.TextBox();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxProductQty = new System.Windows.Forms.NumericUpDown();
            this.txtBoxDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSubmitSalesRecord = new System.Windows.Forms.Button();
            this.btnBrowseProduct = new System.Windows.Forms.Button();
            this.dataGridSalesProduct = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxProductQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 509);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grand Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sale ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(739, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Qty";
            // 
            // txtBoxGrandTotal
            // 
            this.txtBoxGrandTotal.Location = new System.Drawing.Point(805, 509);
            this.txtBoxGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxGrandTotal.Name = "txtBoxGrandTotal";
            this.txtBoxGrandTotal.ReadOnly = true;
            this.txtBoxGrandTotal.Size = new System.Drawing.Size(132, 22);
            this.txtBoxGrandTotal.TabIndex = 13;
            // 
            // txtBoxSalesID
            // 
            this.txtBoxSalesID.Location = new System.Drawing.Point(349, 28);
            this.txtBoxSalesID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSalesID.Name = "txtBoxSalesID";
            this.txtBoxSalesID.ReadOnly = true;
            this.txtBoxSalesID.Size = new System.Drawing.Size(193, 22);
            this.txtBoxSalesID.TabIndex = 15;
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.Location = new System.Drawing.Point(207, 112);
            this.txtBoxProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.ReadOnly = true;
            this.txtBoxProductID.Size = new System.Drawing.Size(165, 22);
            this.txtBoxProductID.TabIndex = 0;
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(381, 112);
            this.txtBoxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.ReadOnly = true;
            this.txtBoxProductName.Size = new System.Drawing.Size(325, 22);
            this.txtBoxProductName.TabIndex = 1;
            // 
            // txtBoxProductQty
            // 
            this.txtBoxProductQty.Location = new System.Drawing.Point(716, 112);
            this.txtBoxProductQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProductQty.Name = "txtBoxProductQty";
            this.txtBoxProductQty.Size = new System.Drawing.Size(160, 22);
            this.txtBoxProductQty.TabIndex = 2;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Enabled = false;
            this.txtBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBoxDate.Location = new System.Drawing.Point(648, 28);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(133, 26);
            this.txtBoxDate.TabIndex = 17;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Image = global::TestForms.Properties.Resources.add;
            this.btnAddProduct.Location = new System.Drawing.Point(947, 112);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(67, 61);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::TestForms.Properties.Resources.cancel;
            this.button3.Location = new System.Drawing.Point(943, 603);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 61);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btnSubmitSalesRecord
            // 
            this.btnSubmitSalesRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitSalesRecord.FlatAppearance.BorderSize = 0;
            this.btnSubmitSalesRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitSalesRecord.Image = global::TestForms.Properties.Resources.confirm;
            this.btnSubmitSalesRecord.Location = new System.Drawing.Point(868, 603);
            this.btnSubmitSalesRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitSalesRecord.Name = "btnSubmitSalesRecord";
            this.btnSubmitSalesRecord.Size = new System.Drawing.Size(67, 61);
            this.btnSubmitSalesRecord.TabIndex = 0;
            this.btnSubmitSalesRecord.UseVisualStyleBackColor = false;
            this.btnSubmitSalesRecord.Click += new System.EventHandler(this.btnSubmitSalesRecord_Click);
            // 
            // btnBrowseProduct
            // 
            this.btnBrowseProduct.Location = new System.Drawing.Point(29, 112);
            this.btnBrowseProduct.Name = "btnBrowseProduct";
            this.btnBrowseProduct.Size = new System.Drawing.Size(139, 29);
            this.btnBrowseProduct.TabIndex = 18;
            this.btnBrowseProduct.Text = "browse product";
            this.btnBrowseProduct.UseVisualStyleBackColor = true;
            this.btnBrowseProduct.Click += new System.EventHandler(this.btnBrowseProduct_Click);
            // 
            // dataGridSalesProduct
            // 
            this.dataGridSalesProduct.AllowUserToAddRows = false;
            this.dataGridSalesProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalesProduct.Location = new System.Drawing.Point(171, 208);
            this.dataGridSalesProduct.Name = "dataGridSalesProduct";
            this.dataGridSalesProduct.ReadOnly = true;
            this.dataGridSalesProduct.RowTemplate.Height = 24;
            this.dataGridSalesProduct.Size = new System.Drawing.Size(767, 283);
            this.dataGridSalesProduct.TabIndex = 19;
            this.dataGridSalesProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSalesProduct_CellDoubleClick);
            this.dataGridSalesProduct.SelectionChanged += new System.EventHandler(this.dataGridSalesProduct_SelectionChanged);
            this.dataGridSalesProduct.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridSalesProduct_UserDeletingRow);
            // 
            // txtBoxProductPrice
            // 
            this.txtBoxProductPrice.Location = new System.Drawing.Point(207, 169);
            this.txtBoxProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProductPrice.Name = "txtBoxProductPrice";
            this.txtBoxProductPrice.ReadOnly = true;
            this.txtBoxProductPrice.Size = new System.Drawing.Size(165, 22);
            this.txtBoxProductPrice.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Product Price";
            // 
            // AddEditSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 691);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxProductPrice);
            this.Controls.Add(this.txtBoxProductQty);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.txtBoxProductID);
            this.Controls.Add(this.dataGridSalesProduct);
            this.Controls.Add(this.btnBrowseProduct);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtBoxSalesID);
            this.Controls.Add(this.txtBoxGrandTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSubmitSalesRecord);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxGrandTotal;
        private System.Windows.Forms.TextBox txtBoxSalesID;
        private System.Windows.Forms.TextBox txtBoxProductID;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.NumericUpDown txtBoxProductQty;
        private System.Windows.Forms.DateTimePicker txtBoxDate;
        private System.Windows.Forms.Button btnBrowseProduct;
        private System.Windows.Forms.DataGridView dataGridSalesProduct;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtBoxProductPrice;
        private System.Windows.Forms.Label label4;
    }
}