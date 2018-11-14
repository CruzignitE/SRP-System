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
            this.components = new System.ComponentModel.Container();
            this.panel_details = new System.Windows.Forms.Panel();
            this.dataGridView_logRefunds = new System.Windows.Forms.DataGridView();
            this.refundBSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_logRefunds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundBSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_details
            // 
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_details.Location = new System.Drawing.Point(0, 578);
            this.panel_details.Margin = new System.Windows.Forms.Padding(4);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(1045, 112);
            this.panel_details.TabIndex = 31;
            // 
            // dataGridView_logRefunds
            // 
            this.dataGridView_logRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_logRefunds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_logRefunds.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_logRefunds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_logRefunds.Name = "dataGridView_logRefunds";
            this.dataGridView_logRefunds.RowTemplate.Height = 24;
            this.dataGridView_logRefunds.Size = new System.Drawing.Size(1045, 690);
            this.dataGridView_logRefunds.TabIndex = 30;
            // 
            // Refunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.panel_details);
            this.Controls.Add(this.dataGridView_logRefunds);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Refunds";
            this.Text = "Refunds";
            this.Load += new System.EventHandler(this.Refunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_logRefunds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundBSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.DataGridView dataGridView_logRefunds;
        private System.Windows.Forms.BindingSource refundBSource;
    }
}