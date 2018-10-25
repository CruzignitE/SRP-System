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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txtBox_hint = new System.Windows.Forms.TextBox();
            this.label_hint = new System.Windows.Forms.Label();
            this.txtBox_newPass = new System.Windows.Forms.TextBox();
            this.label_newPass = new System.Windows.Forms.Label();
            this.txtBox_reenterPass = new System.Windows.Forms.TextBox();
            this.label_reenterPass = new System.Windows.Forms.Label();
            this.txtBox_currentPass = new System.Windows.Forms.TextBox();
            this.label_currentPass = new System.Windows.Forms.Label();
            this.panel_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_details
            // 
            this.panel_details.Controls.Add(this.btn_cancel);
            this.panel_details.Controls.Add(this.btn_confirm);
            this.panel_details.Controls.Add(this.txtBox_hint);
            this.panel_details.Controls.Add(this.label_hint);
            this.panel_details.Controls.Add(this.txtBox_newPass);
            this.panel_details.Controls.Add(this.label_newPass);
            this.panel_details.Controls.Add(this.txtBox_reenterPass);
            this.panel_details.Controls.Add(this.label_reenterPass);
            this.panel_details.Controls.Add(this.txtBox_currentPass);
            this.panel_details.Controls.Add(this.label_currentPass);
            this.panel_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_details.Location = new System.Drawing.Point(0, 0);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(314, 340);
            this.panel_details.TabIndex = 30;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = global::TestForms.Properties.Resources.cancel;
            this.btn_cancel.Location = new System.Drawing.Point(160, 274);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(50, 50);
            this.btn_cancel.TabIndex = 44;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Image = global::TestForms.Properties.Resources.confirm;
            this.btn_confirm.Location = new System.Drawing.Point(95, 274);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(50, 50);
            this.btn_confirm.TabIndex = 43;
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // txtBox_hint
            // 
            this.txtBox_hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBox_hint.Location = new System.Drawing.Point(12, 165);
            this.txtBox_hint.Multiline = true;
            this.txtBox_hint.Name = "txtBox_hint";
            this.txtBox_hint.Size = new System.Drawing.Size(289, 94);
            this.txtBox_hint.TabIndex = 9;
            // 
            // label_hint
            // 
            this.label_hint.AutoSize = true;
            this.label_hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_hint.Location = new System.Drawing.Point(42, 145);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(98, 17);
            this.label_hint.TabIndex = 8;
            this.label_hint.Text = "Password Hint";
            // 
            // txtBox_newPass
            // 
            this.txtBox_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBox_newPass.Location = new System.Drawing.Point(148, 98);
            this.txtBox_newPass.Name = "txtBox_newPass";
            this.txtBox_newPass.PasswordChar = '*';
            this.txtBox_newPass.Size = new System.Drawing.Size(153, 23);
            this.txtBox_newPass.TabIndex = 7;
            this.txtBox_newPass.UseSystemPasswordChar = true;
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
            // txtBox_reenterPass
            // 
            this.txtBox_reenterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBox_reenterPass.Location = new System.Drawing.Point(148, 57);
            this.txtBox_reenterPass.Name = "txtBox_reenterPass";
            this.txtBox_reenterPass.PasswordChar = '*';
            this.txtBox_reenterPass.Size = new System.Drawing.Size(153, 23);
            this.txtBox_reenterPass.TabIndex = 5;
            this.txtBox_reenterPass.UseSystemPasswordChar = true;
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
            // txtBox_currentPass
            // 
            this.txtBox_currentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBox_currentPass.Location = new System.Drawing.Point(148, 17);
            this.txtBox_currentPass.Name = "txtBox_currentPass";
            this.txtBox_currentPass.PasswordChar = '*';
            this.txtBox_currentPass.Size = new System.Drawing.Size(153, 23);
            this.txtBox_currentPass.TabIndex = 1;
            this.txtBox_currentPass.UseSystemPasswordChar = true;
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
            // ManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 340);
            this.Controls.Add(this.panel_details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManagerControl";
            this.Text = "Manager Control";
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.TextBox txtBox_hint;
        private System.Windows.Forms.Label label_hint;
        private System.Windows.Forms.TextBox txtBox_newPass;
        private System.Windows.Forms.Label label_newPass;
        private System.Windows.Forms.TextBox txtBox_reenterPass;
        private System.Windows.Forms.Label label_reenterPass;
        private System.Windows.Forms.TextBox txtBox_currentPass;
        private System.Windows.Forms.Label label_currentPass;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
    }
}