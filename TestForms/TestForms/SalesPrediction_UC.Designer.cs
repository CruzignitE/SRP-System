﻿namespace TestForms
{
    partial class SalesPrediction_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_salesPredictions = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_date = new System.Windows.Forms.TableLayoutPanel();
            this.label_until = new System.Windows.Forms.Label();
            this.dateTimePicker_until = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.label_from = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel_salesPredictions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel_date.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_salesPredictions
            // 
            this.panel_salesPredictions.ColumnCount = 1;
            this.panel_salesPredictions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_salesPredictions.Controls.Add(this.chart1, 0, 0);
            this.panel_salesPredictions.Controls.Add(this.panel_date, 0, 2);
            this.panel_salesPredictions.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.panel_salesPredictions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_salesPredictions.Location = new System.Drawing.Point(0, 0);
            this.panel_salesPredictions.Name = "panel_salesPredictions";
            this.panel_salesPredictions.RowCount = 3;
            this.panel_salesPredictions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_salesPredictions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_salesPredictions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panel_salesPredictions.Size = new System.Drawing.Size(660, 600);
            this.panel_salesPredictions.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(652, 472);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // panel_date
            // 
            this.panel_date.ColumnCount = 5;
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_date.Controls.Add(this.label_until, 3, 0);
            this.panel_date.Controls.Add(this.dateTimePicker_until, 3, 1);
            this.panel_date.Controls.Add(this.dateTimePicker_from, 1, 1);
            this.panel_date.Controls.Add(this.label_from, 1, 0);
            this.panel_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_date.Location = new System.Drawing.Point(3, 523);
            this.panel_date.Name = "panel_date";
            this.panel_date.RowCount = 3;
            this.panel_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_date.Size = new System.Drawing.Size(654, 74);
            this.panel_date.TabIndex = 3;
            // 
            // label_until
            // 
            this.label_until.AutoSize = true;
            this.label_until.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_until.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_until.Location = new System.Drawing.Point(405, 5);
            this.label_until.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label_until.Name = "label_until";
            this.label_until.Size = new System.Drawing.Size(94, 20);
            this.label_until.TabIndex = 3;
            this.label_until.Text = "Until";
            this.label_until.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_until
            // 
            this.dateTimePicker_until.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_until.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_until.Location = new System.Drawing.Point(405, 35);
            this.dateTimePicker_until.Name = "dateTimePicker_until";
            this.dateTimePicker_until.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker_until.TabIndex = 1;
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_from.Location = new System.Drawing.Point(154, 35);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker_from.TabIndex = 0;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_from.Location = new System.Drawing.Point(154, 5);
            this.label_from.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(94, 20);
            this.label_from.TabIndex = 2;
            this.label_from.Text = "From";
            this.label_from.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_category, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 483);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 34);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_category.Location = new System.Drawing.Point(130, 5);
            this.label_category.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(94, 24);
            this.label_category.TabIndex = 3;
            this.label_category.Text = "Category";
            this.label_category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(230, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // SalesPrediction_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_salesPredictions);
            this.Name = "SalesPrediction_UC";
            this.Size = new System.Drawing.Size(660, 600);
            this.Load += new System.EventHandler(this.InitDate);
            this.panel_salesPredictions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel_date.ResumeLayout(false);
            this.panel_date.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_salesPredictions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel panel_date;
        private System.Windows.Forms.Label label_until;
        private System.Windows.Forms.DateTimePicker dateTimePicker_until;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}