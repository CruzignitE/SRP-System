using System.Windows.Forms;

namespace SRP_System
{
    partial class SRP_System
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
            this.panel_sidebar = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ManagerControl = new System.Windows.Forms.Button();
            this.label_logo = new System.Windows.Forms.Label();
            this.button_side_salesRecords = new System.Windows.Forms.Button();
            this.button_side_products = new System.Windows.Forms.Button();
            this.button_side_inventory = new System.Windows.Forms.Button();
            this.button_side_salesPrediction = new System.Windows.Forms.Button();
            this.uc_salesRecords = new SalesRecords_UC();
            this.uc_products = new ProductsList_UC();
            this.uc_inventory = new Inventory_UC();
            this.uc_salesPrediction = new SalesPrediction_UC();
            this.panel_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(70)))), ((int)(((byte)(96)))));
            this.panel_sidebar.ColumnCount = 1;
            this.panel_sidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_sidebar.Controls.Add(this.btn_ManagerControl, 0, 5);
            this.panel_sidebar.Controls.Add(this.label_logo, 0, 0);
            this.panel_sidebar.Controls.Add(this.button_side_salesRecords, 0, 1);
            this.panel_sidebar.Controls.Add(this.button_side_products, 0, 2);
            this.panel_sidebar.Controls.Add(this.button_side_inventory, 0, 3);
            this.panel_sidebar.Controls.Add(this.button_side_salesPrediction, 0, 4);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.ForeColor = System.Drawing.Color.White;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.RowCount = 8;
            this.panel_sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel_sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.panel_sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.panel_sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.panel_sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.panel_sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel_sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panel_sidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_sidebar.Size = new System.Drawing.Size(123, 721);
            this.panel_sidebar.TabIndex = 23;
            // 
            // btn_ManagerControl
            // 
            this.btn_ManagerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ManagerControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ManagerControl.ForeColor = System.Drawing.Color.Black;
            this.btn_ManagerControl.Location = new System.Drawing.Point(2, 492);
            this.btn_ManagerControl.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ManagerControl.Name = "btn_ManagerControl";
            this.btn_ManagerControl.Size = new System.Drawing.Size(119, 46);
            this.btn_ManagerControl.TabIndex = 23;
            this.btn_ManagerControl.Text = "Manager Control";
            this.btn_ManagerControl.UseVisualStyleBackColor = true;
            this.btn_ManagerControl.Click += new System.EventHandler(this.Btn_ManagerControl_Click);
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.BackColor = System.Drawing.Color.Transparent;
            this.label_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_logo.Location = new System.Drawing.Point(2, 0);
            this.label_logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(119, 50);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "SRP System";
            this.label_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_side_salesRecords
            // 
            this.button_side_salesRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(56)))));
            this.button_side_salesRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_side_salesRecords.FlatAppearance.BorderSize = 0;
            this.button_side_salesRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_side_salesRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_side_salesRecords.ForeColor = System.Drawing.Color.White;
            this.button_side_salesRecords.Image = global::SRP_System.Properties.Resources.sales_records;
            this.button_side_salesRecords.Location = new System.Drawing.Point(2, 52);
            this.button_side_salesRecords.Margin = new System.Windows.Forms.Padding(2);
            this.button_side_salesRecords.Name = "button_side_salesRecords";
            this.button_side_salesRecords.Size = new System.Drawing.Size(119, 106);
            this.button_side_salesRecords.TabIndex = 1;
            this.button_side_salesRecords.Text = "Sales Records";
            this.button_side_salesRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_side_salesRecords.UseVisualStyleBackColor = false;
            this.button_side_salesRecords.Click += new System.EventHandler(this.Btn_Sidebar_Click);
            // 
            // button_side_products
            // 
            this.button_side_products.BackColor = System.Drawing.Color.Transparent;
            this.button_side_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_side_products.FlatAppearance.BorderSize = 0;
            this.button_side_products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_side_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_side_products.ForeColor = System.Drawing.Color.White;
            this.button_side_products.Image = global::SRP_System.Properties.Resources.products1;
            this.button_side_products.Location = new System.Drawing.Point(2, 162);
            this.button_side_products.Margin = new System.Windows.Forms.Padding(2);
            this.button_side_products.Name = "button_side_products";
            this.button_side_products.Size = new System.Drawing.Size(119, 106);
            this.button_side_products.TabIndex = 2;
            this.button_side_products.Text = "Product List";
            this.button_side_products.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_side_products.UseVisualStyleBackColor = false;
            this.button_side_products.Click += new System.EventHandler(this.Btn_Sidebar_Click);
            // 
            // button_side_inventory
            // 
            this.button_side_inventory.BackColor = System.Drawing.Color.Transparent;
            this.button_side_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_side_inventory.FlatAppearance.BorderSize = 0;
            this.button_side_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_side_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_side_inventory.ForeColor = System.Drawing.Color.White;
            this.button_side_inventory.Image = global::SRP_System.Properties.Resources.inventory;
            this.button_side_inventory.Location = new System.Drawing.Point(2, 272);
            this.button_side_inventory.Margin = new System.Windows.Forms.Padding(2);
            this.button_side_inventory.Name = "button_side_inventory";
            this.button_side_inventory.Size = new System.Drawing.Size(119, 106);
            this.button_side_inventory.TabIndex = 3;
            this.button_side_inventory.Text = "Inventory";
            this.button_side_inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_side_inventory.UseVisualStyleBackColor = false;
            this.button_side_inventory.Click += new System.EventHandler(this.Btn_Sidebar_Click);
            // 
            // button_side_salesPrediction
            // 
            this.button_side_salesPrediction.BackColor = System.Drawing.Color.Transparent;
            this.button_side_salesPrediction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_side_salesPrediction.FlatAppearance.BorderSize = 0;
            this.button_side_salesPrediction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_side_salesPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_side_salesPrediction.ForeColor = System.Drawing.Color.White;
            this.button_side_salesPrediction.Image = global::SRP_System.Properties.Resources.prediction;
            this.button_side_salesPrediction.Location = new System.Drawing.Point(2, 382);
            this.button_side_salesPrediction.Margin = new System.Windows.Forms.Padding(2);
            this.button_side_salesPrediction.Name = "button_side_salesPrediction";
            this.button_side_salesPrediction.Size = new System.Drawing.Size(119, 106);
            this.button_side_salesPrediction.TabIndex = 4;
            this.button_side_salesPrediction.Text = "Sales Predictions";
            this.button_side_salesPrediction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_side_salesPrediction.UseVisualStyleBackColor = false;
            this.button_side_salesPrediction.Click += new System.EventHandler(this.Btn_Sidebar_Click);
            // 
            // uc_salesRecords
            // 
            this.uc_salesRecords.BackColor = System.Drawing.Color.White;
            this.uc_salesRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_salesRecords.Location = new System.Drawing.Point(123, 0);
            this.uc_salesRecords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uc_salesRecords.Name = "uc_salesRecords";
            this.uc_salesRecords.Size = new System.Drawing.Size(883, 721);
            this.uc_salesRecords.TabIndex = 22;
            // 
            // uc_products
            // 
            this.uc_products.BackColor = System.Drawing.Color.White;
            this.uc_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uc_products.Location = new System.Drawing.Point(123, 0);
            this.uc_products.Margin = new System.Windows.Forms.Padding(4);
            this.uc_products.Name = "uc_products";
            this.uc_products.Size = new System.Drawing.Size(883, 721);
            this.uc_products.TabIndex = 25;
            this.uc_products.Visible = false;
            // 
            // uc_inventory
            // 
            this.uc_inventory.BackColor = System.Drawing.Color.White;
            this.uc_inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uc_inventory.Location = new System.Drawing.Point(123, 0);
            this.uc_inventory.Margin = new System.Windows.Forms.Padding(4);
            this.uc_inventory.Name = "uc_inventory";
            this.uc_inventory.Size = new System.Drawing.Size(883, 721);
            this.uc_inventory.TabIndex = 24;
            this.uc_inventory.Visible = false;
            // 
            // uc_salesPrediction
            // 
            this.uc_salesPrediction.BackColor = System.Drawing.Color.White;
            this.uc_salesPrediction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_salesPrediction.Location = new System.Drawing.Point(123, 0);
            this.uc_salesPrediction.Margin = new System.Windows.Forms.Padding(4);
            this.uc_salesPrediction.Name = "uc_salesPrediction";
            this.uc_salesPrediction.Size = new System.Drawing.Size(883, 721);
            this.uc_salesPrediction.TabIndex = 26;
            this.uc_salesPrediction.Visible = false;
            // 
            // SRP_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.uc_salesRecords);
            this.Controls.Add(this.uc_products);
            this.Controls.Add(this.uc_inventory);
            this.Controls.Add(this.uc_salesPrediction);
            this.Controls.Add(this.panel_sidebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "SRP_System";
            this.Text = "SRP_System";
            this.Load += new System.EventHandler(this.DatabaseBackup);
            this.panel_sidebar.ResumeLayout(false);
            this.panel_sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel panel_sidebar;
        private Button button_side_salesPrediction;
        private Button button_side_salesRecords;
        private Button button_side_inventory;
        private Label label_logo;
        private Button button_side_products;
        private SalesRecords_UC uc_salesRecords;
        private Inventory_UC uc_inventory;
        private ProductsList_UC uc_products;
        private Button btn_ManagerControl;
        private SalesPrediction_UC uc_salesPrediction;
    }
}