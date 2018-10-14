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
            this.dataGridView_stockChanges = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
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
            this.panel_details.Location = new System.Drawing.Point(0, 470);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(784, 91);
            this.panel_details.TabIndex = 31;
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
            this.dataGridView_stockChanges.TabIndex = 30;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Image = global::TestForms.Properties.Resources.delete;
            this.deleteButton.Location = new System.Drawing.Point(457, 24);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 46);
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
            this.editButton.Location = new System.Drawing.Point(371, 24);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 46);
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
            this.addButton.Location = new System.Drawing.Point(281, 24);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 46);
            this.addButton.TabIndex = 27;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // Refunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.dataGridView_stockChanges);
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