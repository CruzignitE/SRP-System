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
            this.components = new System.ComponentModel.Container();
            this.dataGVStockChanges = new System.Windows.Forms.DataGridView();
            this.panel_details = new System.Windows.Forms.Panel();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.label_qty = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.txtBoxCategory = new System.Windows.Forms.TextBox();
            this.label_category = new System.Windows.Forms.Label();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.txtBoxProductID = new System.Windows.Forms.TextBox();
            this.label_productID = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStockChanges)).BeginInit();
            this.panel_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVStockChanges
            // 
            this.dataGVStockChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVStockChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVStockChanges.Location = new System.Drawing.Point(0, 0);
            this.dataGVStockChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGVStockChanges.Name = "dataGVStockChanges";
            this.dataGVStockChanges.RowTemplate.Height = 24;
            this.dataGVStockChanges.Size = new System.Drawing.Size(1171, 690);
            this.dataGVStockChanges.TabIndex = 28;
            this.dataGVStockChanges.SelectionChanged += new System.EventHandler(this.dataGVStockChanges_SelectionChanged);
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.txtBoxQuantity);
            this.panel_details.Controls.Add(this.label_qty);
            this.panel_details.Controls.Add(this.txtBoxDescription);
            this.panel_details.Controls.Add(this.label_comment);
            this.panel_details.Controls.Add(this.txtBoxCategory);
            this.panel_details.Controls.Add(this.label_category);
            this.panel_details.Controls.Add(this.txtBoxDate);
            this.panel_details.Controls.Add(this.label_date);
            this.panel_details.Controls.Add(this.txtBoxProductID);
            this.panel_details.Controls.Add(this.label_productID);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_details.Location = new System.Drawing.Point(0, 558);
            this.panel_details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(1171, 132);
            this.panel_details.TabIndex = 29;
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Enabled = false;
            this.txtBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxQuantity.Location = new System.Drawing.Point(799, 21);
            this.txtBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(203, 26);
            this.txtBoxQuantity.TabIndex = 9;
            // 
            // label_qty
            // 
            this.label_qty.AutoSize = true;
            this.label_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_qty.Location = new System.Drawing.Point(709, 25);
            this.label_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_qty.Name = "label_qty";
            this.label_qty.Size = new System.Drawing.Size(71, 20);
            this.label_qty.TabIndex = 8;
            this.label_qty.Text = "Quantity";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Enabled = false;
            this.txtBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDescription.Location = new System.Drawing.Point(463, 70);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(539, 26);
            this.txtBoxDescription.TabIndex = 7;
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_comment.Location = new System.Drawing.Point(349, 74);
            this.label_comment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(95, 20);
            this.label_comment.TabIndex = 6;
            this.label_comment.Text = "Description";
            // 
            // txtBoxCategory
            // 
            this.txtBoxCategory.Enabled = false;
            this.txtBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxCategory.Location = new System.Drawing.Point(136, 70);
            this.txtBoxCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.txtBoxCategory.Size = new System.Drawing.Size(203, 26);
            this.txtBoxCategory.TabIndex = 5;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_category.Location = new System.Drawing.Point(41, 74);
            this.label_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(76, 20);
            this.label_category.TabIndex = 4;
            this.label_category.Text = "Category";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Enabled = false;
            this.txtBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxDate.Location = new System.Drawing.Point(463, 21);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(203, 26);
            this.txtBoxDate.TabIndex = 3;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_date.Location = new System.Drawing.Point(404, 25);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(45, 20);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Date";
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.Enabled = false;
            this.txtBoxProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxProductID.Location = new System.Drawing.Point(136, 21);
            this.txtBoxProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.Size = new System.Drawing.Size(203, 26);
            this.txtBoxProductID.TabIndex = 1;
            // 
            // label_productID
            // 
            this.label_productID.AutoSize = true;
            this.label_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_productID.Location = new System.Drawing.Point(29, 25);
            this.label_productID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_productID.Name = "label_productID";
            this.label_productID.Size = new System.Drawing.Size(89, 20);
            this.label_productID.TabIndex = 0;
            this.label_productID.Text = "Product ID";
            // 
            // StockChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 690);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.dataGVStockChanges);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StockChanges";
            this.Text = "Stock Changes";
            this.Load += new System.EventHandler(this.StockChanges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStockChanges)).EndInit();
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVStockChanges;
        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.Label label_qty;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.TextBox txtBoxCategory;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.TextBox txtBoxProductID;
        private System.Windows.Forms.Label label_productID;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}