namespace SRP_System
{
    partial class RefundAdd
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
            this.label_desc = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label_pName = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.label_pID = new System.Windows.Forms.Label();
            this.txtBoxProductID = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label_qty = new System.Windows.Forms.Label();
            this.textBox_managerPass = new System.Windows.Forms.TextBox();
            this.label_managerPass = new System.Windows.Forms.Label();
            this.txtBoxQty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_desc.Location = new System.Drawing.Point(40, 121);
            this.label_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(100, 20);
            this.label_desc.TabIndex = 12;
            this.label_desc.Text = "Description:";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDescription.Location = new System.Drawing.Point(44, 145);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(699, 26);
            this.txtBoxDescription.TabIndex = 11;
            // 
            // label_pName
            // 
            this.label_pName.AutoSize = true;
            this.label_pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_pName.Location = new System.Drawing.Point(276, 41);
            this.label_pName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pName.Name = "label_pName";
            this.label_pName.Size = new System.Drawing.Size(121, 20);
            this.label_pName.TabIndex = 10;
            this.label_pName.Text = "Product Name:";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Enabled = false;
            this.txtBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxProductName.Location = new System.Drawing.Point(280, 65);
            this.txtBoxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(463, 26);
            this.txtBoxProductName.TabIndex = 9;
            // 
            // label_pID
            // 
            this.label_pID.AutoSize = true;
            this.label_pID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_pID.Location = new System.Drawing.Point(40, 41);
            this.label_pID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_pID.Name = "label_pID";
            this.label_pID.Size = new System.Drawing.Size(94, 20);
            this.label_pID.TabIndex = 8;
            this.label_pID.Text = "Product ID:";
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.Enabled = false;
            this.txtBoxProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxProductID.Location = new System.Drawing.Point(44, 65);
            this.txtBoxProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.Size = new System.Drawing.Size(184, 26);
            this.txtBoxProductID.TabIndex = 7;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = global::SRP_System.Properties.Resources.cancel;
            this.editButton.Location = new System.Drawing.Point(928, 180);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(67, 62);
            this.editButton.TabIndex = 29;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::SRP_System.Properties.Resources.confirm;
            this.addButton.Location = new System.Drawing.Point(841, 180);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(67, 62);
            this.addButton.TabIndex = 28;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_qty.Location = new System.Drawing.Point(792, 41);
            this.label_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(76, 20);
            this.label_qty.TabIndex = 31;
            this.label_qty.Text = "Quantity:";
            // 
            // textBox_managerPass
            // 
            this.textBox_managerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_managerPass.Location = new System.Drawing.Point(583, 213);
            this.textBox_managerPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_managerPass.Name = "textBox_managerPass";
            this.textBox_managerPass.PasswordChar = '*';
            this.textBox_managerPass.Size = new System.Drawing.Size(160, 26);
            this.textBox_managerPass.TabIndex = 42;
            // 
            // label_managerPass
            // 
            this.label_managerPass.AutoSize = true;
            this.label_managerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_managerPass.Location = new System.Drawing.Point(397, 217);
            this.label_managerPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_managerPass.Name = "label_managerPass";
            this.label_managerPass.Size = new System.Drawing.Size(158, 20);
            this.label_managerPass.TabIndex = 41;
            this.label_managerPass.Text = "Manager Password:";
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxQty.Location = new System.Drawing.Point(796, 65);
            this.txtBoxQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(160, 26);
            this.txtBoxQty.TabIndex = 43;
            this.txtBoxQty.ValueChanged += new System.EventHandler(this.txtBoxQty_ValueChanged);
            // 
            // RefundAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 273);
            this.Controls.Add(this.txtBoxQty);
            this.Controls.Add(this.textBox_managerPass);
            this.Controls.Add(this.label_managerPass);
            this.Controls.Add(this.label_qty);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label_desc);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.label_pName);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.label_pID);
            this.Controls.Add(this.txtBoxProductID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RefundAdd";
            this.Text = "Add Refund";
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label_pName;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.Label label_pID;
        private System.Windows.Forms.TextBox txtBoxProductID;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label_qty;
        private System.Windows.Forms.TextBox textBox_managerPass;
        private System.Windows.Forms.Label label_managerPass;
        private System.Windows.Forms.NumericUpDown txtBoxQty;
    }
}