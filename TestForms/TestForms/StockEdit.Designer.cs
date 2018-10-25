namespace TestForms
{
    partial class StockEdit
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
            this.txtBoxExpiry = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxArrival = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxProductID = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCurrentQty = new System.Windows.Forms.TextBox();
            this.txtBoxEditQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxExpiry
            // 
            this.txtBoxExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBoxExpiry.Location = new System.Drawing.Point(216, 144);
            this.txtBoxExpiry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxExpiry.Name = "txtBoxExpiry";
            this.txtBoxExpiry.Size = new System.Drawing.Size(133, 26);
            this.txtBoxExpiry.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(212, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Expiry:";
            // 
            // txtBoxArrival
            // 
            this.txtBoxArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBoxArrival.Location = new System.Drawing.Point(44, 144);
            this.txtBoxArrival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxArrival.Name = "txtBoxArrival";
            this.txtBoxArrival.Size = new System.Drawing.Size(133, 26);
            this.txtBoxArrival.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(40, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Arrival:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(788, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Current Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(276, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Product Name:";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxProductName.Location = new System.Drawing.Point(280, 65);
            this.txtBoxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.ReadOnly = true;
            this.txtBoxProductName.Size = new System.Drawing.Size(463, 26);
            this.txtBoxProductName.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Product ID:";
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxProductID.Location = new System.Drawing.Point(44, 65);
            this.txtBoxProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.ReadOnly = true;
            this.txtBoxProductID.Size = new System.Drawing.Size(184, 26);
            this.txtBoxProductID.TabIndex = 45;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = global::TestForms.Properties.Resources.cancel;
            this.editButton.Location = new System.Drawing.Point(879, 170);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(67, 62);
            this.editButton.TabIndex = 54;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::TestForms.Properties.Resources.confirm;
            this.addButton.Location = new System.Drawing.Point(792, 170);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(67, 62);
            this.addButton.TabIndex = 53;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.Location = new System.Drawing.Point(599, 177);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(160, 26);
            this.textBox4.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(413, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Manager Password:";
            // 
            // txtBoxCurrentQty
            // 
            this.txtBoxCurrentQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxCurrentQty.Location = new System.Drawing.Point(792, 65);
            this.txtBoxCurrentQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCurrentQty.Name = "txtBoxCurrentQty";
            this.txtBoxCurrentQty.ReadOnly = true;
            this.txtBoxCurrentQty.Size = new System.Drawing.Size(165, 26);
            this.txtBoxCurrentQty.TabIndex = 59;
            // 
            // txtBoxEditQty
            // 
            this.txtBoxEditQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxEditQty.Location = new System.Drawing.Point(792, 131);
            this.txtBoxEditQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEditQty.Name = "txtBoxEditQty";
            this.txtBoxEditQty.Size = new System.Drawing.Size(165, 26);
            this.txtBoxEditQty.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(788, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Edit Quantity:";
            // 
            // StockEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 238);
            this.Controls.Add(this.txtBoxEditQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxCurrentQty);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxExpiry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.txtBoxArrival);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxProductID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockEdit";
            this.Text = "Edit Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtBoxExpiry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker txtBoxArrival;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxProductID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCurrentQty;
        private System.Windows.Forms.TextBox txtBoxEditQty;
        private System.Windows.Forms.Label label7;
    }
}