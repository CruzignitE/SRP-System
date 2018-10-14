namespace TestForms
{
    partial class ManagerControl
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
            this.textBox_reenterPass = new System.Windows.Forms.TextBox();
            this.label_reenterPass = new System.Windows.Forms.Label();
            this.textBox_currentPass = new System.Windows.Forms.TextBox();
            this.label_currentPass = new System.Windows.Forms.Label();
            this.textBox_newPass = new System.Windows.Forms.TextBox();
            this.label_newPass = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.editButton);
            this.panel_details.Controls.Add(this.addButton);
            this.panel_details.Controls.Add(this.textBox2);
            this.panel_details.Controls.Add(this.label2);
            this.panel_details.Controls.Add(this.textBox_newPass);
            this.panel_details.Controls.Add(this.label_newPass);
            this.panel_details.Controls.Add(this.textBox_reenterPass);
            this.panel_details.Controls.Add(this.label_reenterPass);
            this.panel_details.Controls.Add(this.textBox_currentPass);
            this.panel_details.Controls.Add(this.label_currentPass);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_details.Location = new System.Drawing.Point(0, 0);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(314, 340);
            this.panel_details.TabIndex = 30;
            // 
            // textBox_reenterPass
            // 
            this.textBox_reenterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_reenterPass.Location = new System.Drawing.Point(148, 57);
            this.textBox_reenterPass.Name = "textBox_reenterPass";
            this.textBox_reenterPass.PasswordChar = '*';
            this.textBox_reenterPass.Size = new System.Drawing.Size(153, 23);
            this.textBox_reenterPass.TabIndex = 5;
            // 
            // label_reenterPass
            // 
            this.label_reenterPass.AutoSize = true;
            this.label_reenterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_reenterPass.Location = new System.Drawing.Point(18, 60);
            this.label_reenterPass.Name = "label_reenterPass";
            this.label_reenterPass.Size = new System.Drawing.Size(124, 17);
            this.label_reenterPass.TabIndex = 4;
            this.label_reenterPass.Text = "Reenter Password";
            // 
            // textBox_currentPass
            // 
            this.textBox_currentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_currentPass.Location = new System.Drawing.Point(148, 17);
            this.textBox_currentPass.Name = "textBox_currentPass";
            this.textBox_currentPass.PasswordChar = '*';
            this.textBox_currentPass.Size = new System.Drawing.Size(153, 23);
            this.textBox_currentPass.TabIndex = 1;
            // 
            // label_currentPass
            // 
            this.label_currentPass.AutoSize = true;
            this.label_currentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_currentPass.Location = new System.Drawing.Point(22, 20);
            this.label_currentPass.Name = "label_currentPass";
            this.label_currentPass.Size = new System.Drawing.Size(120, 17);
            this.label_currentPass.TabIndex = 0;
            this.label_currentPass.Text = "Current Password";
            // 
            // textBox_newPass
            // 
            this.textBox_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_newPass.Location = new System.Drawing.Point(148, 98);
            this.textBox_newPass.Name = "textBox_newPass";
            this.textBox_newPass.PasswordChar = '*';
            this.textBox_newPass.Size = new System.Drawing.Size(153, 23);
            this.textBox_newPass.TabIndex = 7;
            // 
            // label_newPass
            // 
            this.label_newPass.AutoSize = true;
            this.label_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_newPass.Location = new System.Drawing.Point(42, 101);
            this.label_newPass.Name = "label_newPass";
            this.label_newPass.Size = new System.Drawing.Size(100, 17);
            this.label_newPass.TabIndex = 6;
            this.label_newPass.Text = "New Password";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(12, 165);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 94);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(42, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password Hint";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = global::TestForms.Properties.Resources.cancel;
            this.editButton.Location = new System.Drawing.Point(160, 274);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 50);
            this.editButton.TabIndex = 44;
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::TestForms.Properties.Resources.confirm;
            this.addButton.Location = new System.Drawing.Point(95, 274);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 50);
            this.addButton.TabIndex = 43;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 340);
            this.Controls.Add(this.panel_details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManagerControl";
            this.Text = "ManagerControl";
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_newPass;
        private System.Windows.Forms.Label label_newPass;
        private System.Windows.Forms.TextBox textBox_reenterPass;
        private System.Windows.Forms.Label label_reenterPass;
        private System.Windows.Forms.TextBox textBox_currentPass;
        private System.Windows.Forms.Label label_currentPass;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
    }
}