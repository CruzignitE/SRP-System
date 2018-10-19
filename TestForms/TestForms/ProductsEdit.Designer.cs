namespace TestForms
{
    partial class ProductsEdit
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
            this.sltEditPruductStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditProductCategory = new System.Windows.Forms.TextBox();
            this.chkEditProductPerishable = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEditProductPassword = new System.Windows.Forms.TextBox();
            this.txtEditProductUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelEditProductForm = new System.Windows.Forms.Button();
            this.btnSubmitEditProductForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditProductUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // sltEditPruductStatus
            // 
            this.sltEditPruductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sltEditPruductStatus.FormattingEnabled = true;
            this.sltEditPruductStatus.Items.AddRange(new object[] {
            "Active",
            "Retired"});
            this.sltEditPruductStatus.Location = new System.Drawing.Point(363, 109);
            this.sltEditPruductStatus.Name = "sltEditPruductStatus";
            this.sltEditPruductStatus.Size = new System.Drawing.Size(121, 24);
            this.sltEditPruductStatus.TabIndex = 38;
            this.sltEditPruductStatus.Text = "Active";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Category:";
            // 
            // txtEditProductCategory
            // 
            this.txtEditProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEditProductCategory.Location = new System.Drawing.Point(33, 109);
            this.txtEditProductCategory.Name = "txtEditProductCategory";
            this.txtEditProductCategory.Size = new System.Drawing.Size(139, 23);
            this.txtEditProductCategory.TabIndex = 34;
            // 
            // chkEditProductPerishable
            // 
            this.chkEditProductPerishable.AutoSize = true;
            this.chkEditProductPerishable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkEditProductPerishable.Location = new System.Drawing.Point(587, 49);
            this.chkEditProductPerishable.Name = "chkEditProductPerishable";
            this.chkEditProductPerishable.Size = new System.Drawing.Size(102, 21);
            this.chkEditProductPerishable.TabIndex = 33;
            this.chkEditProductPerishable.Text = "Perishable?";
            this.chkEditProductPerishable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(207, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Product Name:";
            // 
            // txtEditProductName
            // 
            this.txtEditProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEditProductName.Location = new System.Drawing.Point(210, 49);
            this.txtEditProductName.Name = "txtEditProductName";
            this.txtEditProductName.Size = new System.Drawing.Size(348, 23);
            this.txtEditProductName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Product ID:";
            // 
            // txtEditProductID
            // 
            this.txtEditProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEditProductID.Location = new System.Drawing.Point(33, 49);
            this.txtEditProductID.Name = "txtEditProductID";
            this.txtEditProductID.ReadOnly = true;
            this.txtEditProductID.Size = new System.Drawing.Size(139, 23);
            this.txtEditProductID.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(224, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Manager Password:";
            // 
            // txtEditProductPassword
            // 
            this.txtEditProductPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEditProductPassword.Location = new System.Drawing.Point(363, 158);
            this.txtEditProductPassword.Name = "txtEditProductPassword";
            this.txtEditProductPassword.PasswordChar = '*';
            this.txtEditProductPassword.Size = new System.Drawing.Size(121, 23);
            this.txtEditProductPassword.TabIndex = 40;
            // 
            // txtEditProductUnitPrice
            // 
            this.txtEditProductUnitPrice.DecimalPlaces = 2;
            this.txtEditProductUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEditProductUnitPrice.InterceptArrowKeys = false;
            this.txtEditProductUnitPrice.Location = new System.Drawing.Point(210, 109);
            this.txtEditProductUnitPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtEditProductUnitPrice.Name = "txtEditProductUnitPrice";
            this.txtEditProductUnitPrice.Size = new System.Drawing.Size(120, 23);
            this.txtEditProductUnitPrice.TabIndex = 42;
            this.txtEditProductUnitPrice.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(207, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Unit Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(360, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Status:";
            // 
            // btnCancelEditProductForm
            // 
            this.btnCancelEditProductForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelEditProductForm.FlatAppearance.BorderSize = 0;
            this.btnCancelEditProductForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEditProductForm.Image = global::TestForms.Properties.Resources.cancel;
            this.btnCancelEditProductForm.Location = new System.Drawing.Point(624, 133);
            this.btnCancelEditProductForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelEditProductForm.Name = "btnCancelEditProductForm";
            this.btnCancelEditProductForm.Size = new System.Drawing.Size(50, 46);
            this.btnCancelEditProductForm.TabIndex = 37;
            this.btnCancelEditProductForm.UseVisualStyleBackColor = false;
            this.btnCancelEditProductForm.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // btnSubmitEditProductForm
            // 
            this.btnSubmitEditProductForm.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitEditProductForm.FlatAppearance.BorderSize = 0;
            this.btnSubmitEditProductForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEditProductForm.Image = global::TestForms.Properties.Resources.confirm;
            this.btnSubmitEditProductForm.Location = new System.Drawing.Point(559, 133);
            this.btnSubmitEditProductForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmitEditProductForm.Name = "btnSubmitEditProductForm";
            this.btnSubmitEditProductForm.Size = new System.Drawing.Size(50, 46);
            this.btnSubmitEditProductForm.TabIndex = 36;
            this.btnSubmitEditProductForm.UseVisualStyleBackColor = false;
            // 
            // ProductsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 200);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEditProductUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEditProductPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sltEditPruductStatus);
            this.Controls.Add(this.btnCancelEditProductForm);
            this.Controls.Add(this.btnSubmitEditProductForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEditProductCategory);
            this.Controls.Add(this.chkEditProductPerishable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEditProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEditProductID);
            this.Name = "ProductsEdit";
            this.Text = "ProductsEdit";
            ((System.ComponentModel.ISupportInitialize)(this.txtEditProductUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sltEditPruductStatus;
        private System.Windows.Forms.Button btnCancelEditProductForm;
        private System.Windows.Forms.Button btnSubmitEditProductForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditProductCategory;
        private System.Windows.Forms.CheckBox chkEditProductPerishable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditProductPassword;
        private System.Windows.Forms.NumericUpDown txtEditProductUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}