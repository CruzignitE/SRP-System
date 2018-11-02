namespace TestForms
{
    partial class ProductsAdd
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.NumericUpDown();
            this.sltCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(33, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(139, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(207, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Name:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxName.Location = new System.Drawing.Point(210, 49);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(348, 23);
            this.txtBoxName.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(587, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Perishable?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(30, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category:";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = global::TestForms.Properties.Resources.cancel;
            this.editButton.Location = new System.Drawing.Point(623, 109);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 46);
            this.editButton.TabIndex = 27;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::TestForms.Properties.Resources.confirm;
            this.addButton.Location = new System.Drawing.Point(558, 109);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 46);
            this.addButton.TabIndex = 26;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(207, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Unit Price:";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.DecimalPlaces = 2;
            this.txtBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxPrice.InterceptArrowKeys = false;
            this.txtBoxPrice.Location = new System.Drawing.Point(210, 109);
            this.txtBoxPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(120, 23);
            this.txtBoxPrice.TabIndex = 30;
            this.txtBoxPrice.ThousandsSeparator = true;
            // 
            // sltCategory
            // 
            this.sltCategory.FormattingEnabled = true;
            this.sltCategory.Items.AddRange(new object[] {
            "Cough, Cold & Nasal Medication",
            "Digestive Health",
            "First Aid",
            "Fitness",
            "Oral Care",
            "Pain Medication",
            "Vitamins & Supplements"});
            this.sltCategory.Location = new System.Drawing.Point(33, 109);
            this.sltCategory.Name = "sltCategory";
            this.sltCategory.Size = new System.Drawing.Size(139, 20);
            this.sltCategory.TabIndex = 31;
            this.sltCategory.Text = "Cough, Cold & Nasal Medication";
            // 
            // ProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 178);
            this.Controls.Add(this.sltCategory);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "ProductsAdd";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtBoxPrice;
        private System.Windows.Forms.ComboBox sltCategory;
    }
}