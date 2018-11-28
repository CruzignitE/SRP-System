namespace SRP_System
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
            this.label_saleID = new System.Windows.Forms.Label();
            this.label_productID = new System.Windows.Forms.Label();
            this.label_productName = new System.Windows.Forms.Label();
            this.label_productQty = new System.Windows.Forms.Label();
            this.txtBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.txtBox_saleID = new System.Windows.Forms.TextBox();
            this.txtBox_productID = new System.Windows.Forms.TextBox();
            this.txtBox_productName = new System.Windows.Forms.TextBox();
            this.txtBox_productQty = new System.Windows.Forms.NumericUpDown();
            this.txtBox_date = new System.Windows.Forms.DateTimePicker();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_browseProduct = new System.Windows.Forms.Button();
            this.dataGridSalesProduct = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtBox_productPrice = new System.Windows.Forms.TextBox();
            this.label_productPrice = new System.Windows.Forms.Label();
            this.label_discount = new System.Windows.Forms.Label();
            this.label_finalPrice = new System.Windows.Forms.Label();
            this.txtBox_finalPrice = new System.Windows.Forms.TextBox();
            this.txtBox_discount = new System.Windows.Forms.TextBox();
            this.btnRefundProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtBox_productQty)).BeginInit();
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
            // label_saleID
            // 
            this.label_saleID.AutoSize = true;
            this.label_saleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saleID.Location = new System.Drawing.Point(261, 28);
            this.label_saleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_saleID.Name = "label_saleID";
            this.label_saleID.Size = new System.Drawing.Size(77, 20);
            this.label_saleID.TabIndex = 5;
            this.label_saleID.Text = "Sale ID:";
            // 
            // label_productID
            // 
            this.label_productID.AutoSize = true;
            this.label_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productID.Location = new System.Drawing.Point(211, 87);
            this.label_productID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_productID.Name = "label_productID";
            this.label_productID.Size = new System.Drawing.Size(99, 20);
            this.label_productID.TabIndex = 7;
            this.label_productID.Text = "Product ID";
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productName.Location = new System.Drawing.Point(493, 87);
            this.label_productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(74, 20);
            this.label_productName.TabIndex = 8;
            this.label_productName.Text = "Product";
            // 
            // label_productQty
            // 
            this.label_productQty.AutoSize = true;
            this.label_productQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productQty.Location = new System.Drawing.Point(743, 87);
            this.label_productQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_productQty.Name = "label_productQty";
            this.label_productQty.Size = new System.Drawing.Size(38, 20);
            this.label_productQty.TabIndex = 9;
            this.label_productQty.Text = "Qty";
            // 
            // txtBoxGrandTotal
            // 
            this.txtBoxGrandTotal.Location = new System.Drawing.Point(805, 509);
            this.txtBoxGrandTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxGrandTotal.Name = "txtBoxGrandTotal";
            this.txtBoxGrandTotal.ReadOnly = true;
            this.txtBoxGrandTotal.Size = new System.Drawing.Size(132, 22);
            this.txtBoxGrandTotal.TabIndex = 13;
            // 
            // txtBox_saleID
            // 
            this.txtBox_saleID.Location = new System.Drawing.Point(349, 28);
            this.txtBox_saleID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_saleID.Name = "txtBox_saleID";
            this.txtBox_saleID.ReadOnly = true;
            this.txtBox_saleID.Size = new System.Drawing.Size(193, 22);
            this.txtBox_saleID.TabIndex = 15;
            // 
            // txtBox_productID
            // 
            this.txtBox_productID.Location = new System.Drawing.Point(201, 112);
            this.txtBox_productID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_productID.Name = "txtBox_productID";
            this.txtBox_productID.ReadOnly = true;
            this.txtBox_productID.Size = new System.Drawing.Size(165, 22);
            this.txtBox_productID.TabIndex = 0;
            // 
            // txtBox_productName
            // 
            this.txtBox_productName.Location = new System.Drawing.Point(381, 112);
            this.txtBox_productName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_productName.Name = "txtBox_productName";
            this.txtBox_productName.ReadOnly = true;
            this.txtBox_productName.Size = new System.Drawing.Size(325, 22);
            this.txtBox_productName.TabIndex = 1;
            // 
            // txtBox_productQty
            // 
            this.txtBox_productQty.Location = new System.Drawing.Point(720, 112);
            this.txtBox_productQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_productQty.Name = "txtBox_productQty";
            this.txtBox_productQty.Size = new System.Drawing.Size(160, 22);
            this.txtBox_productQty.TabIndex = 2;
            this.txtBox_productQty.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // txtBox_date
            // 
            this.txtBox_date.Enabled = false;
            this.txtBox_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBox_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBox_date.Location = new System.Drawing.Point(648, 28);
            this.txtBox_date.Name = "txtBox_date";
            this.txtBox_date.Size = new System.Drawing.Size(133, 26);
            this.txtBox_date.TabIndex = 17;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.Transparent;
            this.btn_addProduct.FlatAppearance.BorderSize = 0;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Image = global::SRP_System.Properties.Resources.add;
            this.btn_addProduct.Location = new System.Drawing.Point(947, 112);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(67, 61);
            this.btn_addProduct.TabIndex = 1;
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = global::SRP_System.Properties.Resources.cancel;
            this.btn_cancel.Location = new System.Drawing.Point(943, 603);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(67, 61);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Image = global::SRP_System.Properties.Resources.confirm;
            this.btn_confirm.Location = new System.Drawing.Point(868, 603);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(67, 61);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btnSubmitSalesRecord_Click);
            // 
            // btn_browseProduct
            // 
            this.btn_browseProduct.Location = new System.Drawing.Point(29, 112);
            this.btn_browseProduct.Name = "btn_browseProduct";
            this.btn_browseProduct.Size = new System.Drawing.Size(139, 29);
            this.btn_browseProduct.TabIndex = 18;
            this.btn_browseProduct.Text = "Browse Products";
            this.btn_browseProduct.UseVisualStyleBackColor = true;
            this.btn_browseProduct.Click += new System.EventHandler(this.btnBrowseProduct_Click);
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
            // txtBox_productPrice
            // 
            this.txtBox_productPrice.Location = new System.Drawing.Point(201, 169);
            this.txtBox_productPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_productPrice.Name = "txtBox_productPrice";
            this.txtBox_productPrice.ReadOnly = true;
            this.txtBox_productPrice.Size = new System.Drawing.Size(165, 22);
            this.txtBox_productPrice.TabIndex = 20;
            // 
            // label_productPrice
            // 
            this.label_productPrice.AutoSize = true;
            this.label_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_productPrice.Location = new System.Drawing.Point(211, 144);
            this.label_productPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_productPrice.Name = "label_productPrice";
            this.label_productPrice.Size = new System.Drawing.Size(124, 20);
            this.label_productPrice.TabIndex = 21;
            this.label_productPrice.Text = "Product Price";
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_discount.Location = new System.Drawing.Point(396, 144);
            this.label_discount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(120, 20);
            this.label_discount.TabIndex = 23;
            this.label_discount.Text = "Discount (%)";
            // 
            // label_finalPrice
            // 
            this.label_finalPrice.AutoSize = true;
            this.label_finalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_finalPrice.Location = new System.Drawing.Point(595, 144);
            this.label_finalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_finalPrice.Name = "label_finalPrice";
            this.label_finalPrice.Size = new System.Drawing.Size(100, 20);
            this.label_finalPrice.TabIndex = 25;
            this.label_finalPrice.Text = "Final Price";
            // 
            // txtBox_finalPrice
            // 
            this.txtBox_finalPrice.Enabled = false;
            this.txtBox_finalPrice.Location = new System.Drawing.Point(560, 169);
            this.txtBox_finalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_finalPrice.Name = "txtBox_finalPrice";
            this.txtBox_finalPrice.ReadOnly = true;
            this.txtBox_finalPrice.Size = new System.Drawing.Size(165, 22);
            this.txtBox_finalPrice.TabIndex = 24;
            // 
            // txtBox_discount
            // 
            this.txtBox_discount.BackColor = System.Drawing.SystemColors.Window;
            this.txtBox_discount.Location = new System.Drawing.Point(381, 169);
            this.txtBox_discount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_discount.MaxLength = 2;
            this.txtBox_discount.Name = "txtBox_discount";
            this.txtBox_discount.ShortcutsEnabled = false;
            this.txtBox_discount.Size = new System.Drawing.Size(165, 22);
            this.txtBox_discount.TabIndex = 22;
            this.txtBox_discount.TextChanged += new System.EventHandler(this.PriceCalculate);
            this.txtBox_discount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            // 
            // btnRefundProduct
            // 
            this.btnRefundProduct.Enabled = false;
            this.btnRefundProduct.Location = new System.Drawing.Point(171, 497);
            this.btnRefundProduct.Name = "btnRefundProduct";
            this.btnRefundProduct.Size = new System.Drawing.Size(116, 46);
            this.btnRefundProduct.TabIndex = 26;
            this.btnRefundProduct.Text = "Refund Product";
            this.btnRefundProduct.UseVisualStyleBackColor = true;
            this.btnRefundProduct.Click += new System.EventHandler(this.btnRefundProduct_Click);
            // 
            // AddEditSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 691);
            this.Controls.Add(this.btnRefundProduct);
            this.Controls.Add(this.label_finalPrice);
            this.Controls.Add(this.txtBox_finalPrice);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.txtBox_discount);
            this.Controls.Add(this.label_productPrice);
            this.Controls.Add(this.txtBox_productPrice);
            this.Controls.Add(this.txtBox_productQty);
            this.Controls.Add(this.txtBox_productName);
            this.Controls.Add(this.txtBox_productID);
            this.Controls.Add(this.dataGridSalesProduct);
            this.Controls.Add(this.btn_browseProduct);
            this.Controls.Add(this.txtBox_date);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.txtBox_saleID);
            this.Controls.Add(this.txtBoxGrandTotal);
            this.Controls.Add(this.label_productQty);
            this.Controls.Add(this.label_productName);
            this.Controls.Add(this.label_productID);
            this.Controls.Add(this.label_saleID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEditSalesRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Check-out";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditSalesRecord_FormClosing);
            this.Load += new System.EventHandler(this.AddEditSalesRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBox_productQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_saleID;
        private System.Windows.Forms.Label label_productID;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.Label label_productQty;
        private System.Windows.Forms.TextBox txtBoxGrandTotal;
        private System.Windows.Forms.TextBox txtBox_saleID;
        private System.Windows.Forms.TextBox txtBox_productID;
        private System.Windows.Forms.TextBox txtBox_productName;
        private System.Windows.Forms.NumericUpDown txtBox_productQty;
        private System.Windows.Forms.DateTimePicker txtBox_date;
        private System.Windows.Forms.Button btn_browseProduct;
        private System.Windows.Forms.DataGridView dataGridSalesProduct;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtBox_productPrice;
        private System.Windows.Forms.Label label_productPrice;
        private System.Windows.Forms.Label label_discount;
        private System.Windows.Forms.Label label_finalPrice;
        private System.Windows.Forms.TextBox txtBox_finalPrice;
        private System.Windows.Forms.TextBox txtBox_discount;
        private System.Windows.Forms.Button btnRefundProduct;
    }
}