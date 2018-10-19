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
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_newPass = new System.Windows.Forms.TextBox();
            this.label_newPass = new System.Windows.Forms.Label();
            this.textBox_reenterPass = new System.Windows.Forms.TextBox();
            this.label_reenterPass = new System.Windows.Forms.Label();
            this.textBox_currentPass = new System.Windows.Forms.TextBox();
            this.label_currentPass = new System.Windows.Forms.Label();
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
            this.panel_details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(419, 418);
            this.panel_details.TabIndex = 30;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Image = global::TestForms.Properties.Resources.cancel;
            this.editButton.Location = new System.Drawing.Point(213, 337);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(67, 62);
            this.editButton.TabIndex = 44;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::TestForms.Properties.Resources.confirm;
            this.addButton.Location = new System.Drawing.Point(127, 337);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(67, 62);
            this.addButton.TabIndex = 43;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(16, 203);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 115);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(56, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password Hint";
            // 
            // textBox_newPass
            // 
            this.textBox_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_newPass.Location = new System.Drawing.Point(197, 121);
            this.textBox_newPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_newPass.Name = "textBox_newPass";
            this.textBox_newPass.PasswordChar = '*';
            this.textBox_newPass.Size = new System.Drawing.Size(203, 26);
            this.textBox_newPass.TabIndex = 7;
            // 
            // label_newPass
            // 
            this.label_newPass.AutoSize = true;
            this.label_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_newPass.Location = new System.Drawing.Point(56, 124);
            this.label_newPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_newPass.Name = "label_newPass";
            this.label_newPass.Size = new System.Drawing.Size(121, 20);
            this.label_newPass.TabIndex = 6;
            this.label_newPass.Text = "New Password";
            // 
            // textBox_reenterPass
            // 
            this.textBox_reenterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_reenterPass.Location = new System.Drawing.Point(197, 70);
            this.textBox_reenterPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_reenterPass.Name = "textBox_reenterPass";
            this.textBox_reenterPass.PasswordChar = '*';
            this.textBox_reenterPass.Size = new System.Drawing.Size(203, 26);
            this.textBox_reenterPass.TabIndex = 5;
            // 
            // label_reenterPass
            // 
            this.label_reenterPass.AutoSize = true;
            this.label_reenterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_reenterPass.Location = new System.Drawing.Point(24, 74);
            this.label_reenterPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_reenterPass.Name = "label_reenterPass";
            this.label_reenterPass.Size = new System.Drawing.Size(147, 20);
            this.label_reenterPass.TabIndex = 4;
            this.label_reenterPass.Text = "Reenter Password";
            // 
            // textBox_currentPass
            // 
            this.textBox_currentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_currentPass.Location = new System.Drawing.Point(197, 21);
            this.textBox_currentPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_currentPass.Name = "textBox_currentPass";
            this.textBox_currentPass.PasswordChar = '*';
            this.textBox_currentPass.Size = new System.Drawing.Size(203, 26);
            this.textBox_currentPass.TabIndex = 1;
            // 
            // label_currentPass
            // 
            this.label_currentPass.AutoSize = true;
            this.label_currentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_currentPass.Location = new System.Drawing.Point(29, 25);
            this.label_currentPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_currentPass.Name = "label_currentPass";
            this.label_currentPass.Size = new System.Drawing.Size(144, 20);
            this.label_currentPass.TabIndex = 0;
            this.label_currentPass.Text = "Current Password";
            // 
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 418);
            this.Controls.Add(this.panel_details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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