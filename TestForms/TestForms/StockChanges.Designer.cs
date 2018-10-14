namespace TestForms
{
    partial class StockChanges
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
            this.dataGridView_stockChanges = new System.Windows.Forms.DataGridView();
            this.panel_details = new System.Windows.Forms.Panel();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.label_qty = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.label_category = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.textBox_productID = new System.Windows.Forms.TextBox();
            this.label_productID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockChanges)).BeginInit();
            this.panel_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_stockChanges
            // 
            this.dataGridView_stockChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_stockChanges.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_stockChanges.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_stockChanges.Name = "dataGridView_stockChanges";
            this.dataGridView_stockChanges.RowTemplate.Height = 24;
            this.dataGridView_stockChanges.Size = new System.Drawing.Size(784, 561);
            this.dataGridView_stockChanges.TabIndex = 28;
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.textBox_qty);
            this.panel_details.Controls.Add(this.label_qty);
            this.panel_details.Controls.Add(this.textBox_comment);
            this.panel_details.Controls.Add(this.label_comment);
            this.panel_details.Controls.Add(this.textBox_category);
            this.panel_details.Controls.Add(this.label_category);
            this.panel_details.Controls.Add(this.textBox_date);
            this.panel_details.Controls.Add(this.label_date);
            this.panel_details.Controls.Add(this.textBox_productID);
            this.panel_details.Controls.Add(this.label_productID);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_details.Location = new System.Drawing.Point(0, 454);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(784, 107);
            this.panel_details.TabIndex = 29;
            // 
            // textBox_qty
            // 
            this.textBox_qty.Enabled = false;
            this.textBox_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_qty.Location = new System.Drawing.Point(599, 17);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.Size = new System.Drawing.Size(153, 23);
            this.textBox_qty.TabIndex = 9;
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_qty.Location = new System.Drawing.Point(532, 20);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(61, 17);
            this.label_qty.TabIndex = 8;
            this.label_qty.Text = "Quantity";
            // 
            // textBox_comment
            // 
            this.textBox_comment.Enabled = false;
            this.textBox_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_comment.Location = new System.Drawing.Point(347, 57);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(405, 23);
            this.textBox_comment.TabIndex = 7;
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_comment.Location = new System.Drawing.Point(262, 60);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(79, 17);
            this.label_comment.TabIndex = 6;
            this.label_comment.Text = "Description";
            // 
            // textBox_category
            // 
            this.textBox_category.Enabled = false;
            this.textBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_category.Location = new System.Drawing.Point(102, 57);
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.Size = new System.Drawing.Size(153, 23);
            this.textBox_category.TabIndex = 5;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_category.Location = new System.Drawing.Point(31, 60);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(65, 17);
            this.label_category.TabIndex = 4;
            this.label_category.Text = "Category";
            // 
            // textBox_date
            // 
            this.textBox_date.Enabled = false;
            this.textBox_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_date.Location = new System.Drawing.Point(347, 17);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(153, 23);
            this.textBox_date.TabIndex = 3;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_date.Location = new System.Drawing.Point(303, 20);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(38, 17);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Date";
            // 
            // textBox_productID
            // 
            this.textBox_productID.Enabled = false;
            this.textBox_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_productID.Location = new System.Drawing.Point(102, 17);
            this.textBox_productID.Name = "textBox_productID";
            this.textBox_productID.Size = new System.Drawing.Size(153, 23);
            this.textBox_productID.TabIndex = 1;
            // 
            // label_productID
            // 
            this.label_productID.AutoSize = true;
            this.label_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_productID.Location = new System.Drawing.Point(22, 20);
            this.label_productID.Name = "label_productID";
            this.label_productID.Size = new System.Drawing.Size(74, 17);
            this.label_productID.TabIndex = 0;
            this.label_productID.Text = "Product ID";
            // 
            // StockChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.dataGridView_stockChanges);
            this.Name = "StockChanges";
            this.Text = "Stock Changes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockChanges)).EndInit();
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_stockChanges;
        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Label label_qty;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.TextBox textBox_productID;
        private System.Windows.Forms.Label label_productID;
    }
}