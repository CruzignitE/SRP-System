namespace TestForms
{
    partial class Refunds
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
            this.panel_details = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView_stockChanges = new System.Windows.Forms.DataGridView();
            this.panel_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.deleteButton);
            this.panel_details.Controls.Add(this.editButton);
            this.panel_details.Controls.Add(this.addButton);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_details.Location = new System.Drawing.Point(0, 578);
            this.panel_details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(1045, 112);
            this.panel_details.TabIndex = 31;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Image = global::TestForms.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(609, 30);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 57);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = global::TestForms.Properties.Resources.edit;
            this.editButton.Location = new System.Drawing.Point(495, 30);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(67, 57);
            this.editButton.TabIndex = 28;
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::TestForms.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(375, 30);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(67, 57);
            this.addButton.TabIndex = 27;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView_stockChanges
            // 
            this.dataGridView_stockChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_stockChanges.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_stockChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_stockChanges.Name = "dataGridView_stockChanges";
            this.dataGridView_stockChanges.RowTemplate.Height = 24;
            this.dataGridView_stockChanges.Size = new System.Drawing.Size(1045, 690);
            this.dataGridView_stockChanges.TabIndex = 30;
            // 
            // Refunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.dataGridView_stockChanges);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Refunds";
            this.Text = "Refunds";
            this.panel_details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockChanges)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.DataGridView dataGridView_stockChanges;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
    }
}