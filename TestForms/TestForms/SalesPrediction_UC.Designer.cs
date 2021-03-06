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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_salesPredictions = new System.Windows.Forms.TableLayoutPanel();
            this.panel_date = new System.Windows.Forms.TableLayoutPanel();
            this.label_until = new System.Windows.Forms.Label();
            this.dateTimePicker_until = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.label_from = new System.Windows.Forms.Label();
            this.btnGenerateGraph = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_category = new System.Windows.Forms.Label();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.prediction_chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prediction_chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prediction_chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.prediction_chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDisplayPrediction = new System.Windows.Forms.Button();
            this.panel_salesPredictions.SuspendLayout();
            this.panel_date.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prediction_chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prediction_chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prediction_chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prediction_chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_salesPredictions
            // 
            this.panel_salesPredictions.ColumnCount = 1;
            this.panel_salesPredictions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_salesPredictions.Controls.Add(this.panel_date, 0, 2);
            this.panel_salesPredictions.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.panel_salesPredictions.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.panel_salesPredictions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_salesPredictions.Location = new System.Drawing.Point(0, 0);
            this.panel_salesPredictions.Margin = new System.Windows.Forms.Padding(4);
            this.panel_salesPredictions.Name = "panel_salesPredictions";
            this.panel_salesPredictions.RowCount = 3;
            this.panel_salesPredictions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_salesPredictions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.panel_salesPredictions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.panel_salesPredictions.Size = new System.Drawing.Size(880, 738);
            this.panel_salesPredictions.TabIndex = 0;
            // 
            // panel_date
            // 
            this.panel_date.ColumnCount = 5;
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.panel_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_date.Controls.Add(this.label_until, 3, 0);
            this.panel_date.Controls.Add(this.dateTimePicker_until, 3, 1);
            this.panel_date.Controls.Add(this.dateTimePicker_from, 1, 1);
            this.panel_date.Controls.Add(this.label_from, 1, 0);
            this.panel_date.Controls.Add(this.btnGenerateGraph, 4, 0);
            this.panel_date.Controls.Add(this.btnDisplayPrediction, 4, 1);
            this.panel_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_date.Location = new System.Drawing.Point(4, 644);
            this.panel_date.Margin = new System.Windows.Forms.Padding(4);
            this.panel_date.Name = "panel_date";
            this.panel_date.RowCount = 3;
            this.panel_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.panel_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.panel_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panel_date.Size = new System.Drawing.Size(872, 90);
            this.panel_date.TabIndex = 3;
            // 
            // label_until
            // 
            this.label_until.AutoSize = true;
            this.label_until.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_until.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_until.Location = new System.Drawing.Point(541, 6);
            this.label_until.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label_until.Name = "label_until";
            this.label_until.Size = new System.Drawing.Size(125, 25);
            this.label_until.TabIndex = 3;
            this.label_until.Text = "Until";
            this.label_until.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_until
            // 
            this.dateTimePicker_until.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_until.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_until.Location = new System.Drawing.Point(541, 44);
            this.dateTimePicker_until.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_until.Name = "dateTimePicker_until";
            this.dateTimePicker_until.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker_until.TabIndex = 1;
            this.dateTimePicker_until.ValueChanged += new System.EventHandler(this.dateTimePicker_until_ValueChanged);
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_from.Location = new System.Drawing.Point(206, 44);
            this.dateTimePicker_from.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker_from.TabIndex = 0;
            this.dateTimePicker_from.ValueChanged += new System.EventHandler(this.dateTimePicker_from_ValueChanged);
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_from.Location = new System.Drawing.Point(206, 6);
            this.label_from.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(125, 25);
            this.label_from.TabIndex = 2;
            this.label_from.Text = "From";
            this.label_from.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerateGraph
            // 
            this.btnGenerateGraph.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGenerateGraph.Location = new System.Drawing.Point(673, 3);
            this.btnGenerateGraph.Name = "btnGenerateGraph";
            this.btnGenerateGraph.Size = new System.Drawing.Size(196, 31);
            this.btnGenerateGraph.TabIndex = 4;
            this.btnGenerateGraph.Text = "Update Graph";
            this.btnGenerateGraph.UseVisualStyleBackColor = true;
            this.btnGenerateGraph.Click += new System.EventHandler(this.btnGenerateGraph_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_category, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbBoxCategory, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 595);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 41);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_category.Location = new System.Drawing.Point(173, 6);
            this.label_category.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(125, 29);
            this.label_category.TabIndex = 3;
            this.label_category.Text = "Category";
            this.label_category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Items.AddRange(new object[] {
            "All",
            "Cough, Cold & Nasal Medication",
            "Digestive Health",
            "First Aid",
            "Fitness",
            "Oral Care",
            "Pain Medication",
            "Vitamins & Supplements"});
            this.cmbBoxCategory.Location = new System.Drawing.Point(306, 4);
            this.cmbBoxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(392, 28);
            this.cmbBoxCategory.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.prediction_chart4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.prediction_chart3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.prediction_chart2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.prediction_chart1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(874, 585);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // prediction_chart4
            // 
            chartArea9.Name = "ChartArea1";
            this.prediction_chart4.ChartAreas.Add(chartArea9);
            this.prediction_chart4.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.prediction_chart4.Legends.Add(legend9);
            this.prediction_chart4.Location = new System.Drawing.Point(440, 295);
            this.prediction_chart4.Name = "prediction_chart4";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.prediction_chart4.Series.Add(series9);
            this.prediction_chart4.Size = new System.Drawing.Size(431, 287);
            this.prediction_chart4.TabIndex = 3;
            this.prediction_chart4.Text = "chart4";
            // 
            // prediction_chart3
            // 
            chartArea10.Name = "ChartArea1";
            this.prediction_chart3.ChartAreas.Add(chartArea10);
            this.prediction_chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.prediction_chart3.Legends.Add(legend10);
            this.prediction_chart3.Location = new System.Drawing.Point(3, 295);
            this.prediction_chart3.Name = "prediction_chart3";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.prediction_chart3.Series.Add(series10);
            this.prediction_chart3.Size = new System.Drawing.Size(431, 287);
            this.prediction_chart3.TabIndex = 2;
            this.prediction_chart3.Text = "chart3";
            // 
            // prediction_chart2
            // 
            chartArea11.Name = "ChartArea1";
            this.prediction_chart2.ChartAreas.Add(chartArea11);
            this.prediction_chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend11.Name = "Legend1";
            this.prediction_chart2.Legends.Add(legend11);
            this.prediction_chart2.Location = new System.Drawing.Point(440, 3);
            this.prediction_chart2.Name = "prediction_chart2";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.prediction_chart2.Series.Add(series11);
            this.prediction_chart2.Size = new System.Drawing.Size(431, 286);
            this.prediction_chart2.TabIndex = 1;
            this.prediction_chart2.Text = "chart2";
            // 
            // prediction_chart1
            // 
            chartArea12.Name = "ChartArea1";
            this.prediction_chart1.ChartAreas.Add(chartArea12);
            this.prediction_chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend12.Name = "Legend1";
            this.prediction_chart1.Legends.Add(legend12);
            this.prediction_chart1.Location = new System.Drawing.Point(3, 3);
            this.prediction_chart1.Name = "prediction_chart1";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.prediction_chart1.Series.Add(series12);
            this.prediction_chart1.Size = new System.Drawing.Size(431, 286);
            this.prediction_chart1.TabIndex = 0;
            this.prediction_chart1.Text = "chart1";
            // 
            // btnDisplayPrediction
            // 
            this.btnDisplayPrediction.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDisplayPrediction.Location = new System.Drawing.Point(673, 40);
            this.btnDisplayPrediction.Name = "btnDisplayPrediction";
            this.btnDisplayPrediction.Size = new System.Drawing.Size(196, 31);
            this.btnDisplayPrediction.TabIndex = 7;
            this.btnDisplayPrediction.Text = "Display Prediction";
            this.btnDisplayPrediction.UseVisualStyleBackColor = true;
            this.btnDisplayPrediction.Click += new System.EventHandler(this.btnDisplayPrediction_Click_1);
            // 
            // SalesPrediction_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_salesPredictions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesPrediction_UC";
            this.Size = new System.Drawing.Size(880, 738);
            this.Load += new System.EventHandler(this.InitDate);
            this.panel_salesPredictions.ResumeLayout(false);
            this.panel_date.ResumeLayout(false);
            this.panel_date.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prediction_chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prediction_chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prediction_chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prediction_chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_salesPredictions;
        private System.Windows.Forms.TableLayoutPanel panel_date;
        private System.Windows.Forms.Label label_until;
        private System.Windows.Forms.DateTimePicker dateTimePicker_until;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.Button btnGenerateGraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart prediction_chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart prediction_chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart prediction_chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart prediction_chart1;
        private System.Windows.Forms.Button btnDisplayPrediction;
    }
}
