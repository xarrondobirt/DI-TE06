namespace GUI.UC
{
    partial class GeneralUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tlpGeneralUC = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGeneralLUC = new System.Windows.Forms.TableLayoutPanel();
            this.labelGeneralLBotUC = new System.Windows.Forms.Label();
            this.labelGeneralLTopUC = new System.Windows.Forms.Label();
            this.chartGeneralUC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpGeneralUC.SuspendLayout();
            this.tlpGeneralLUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralUC)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpGeneralUC
            // 
            this.tlpGeneralUC.ColumnCount = 2;
            this.tlpGeneralUC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.22013F));
            this.tlpGeneralUC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.77988F));
            this.tlpGeneralUC.Controls.Add(this.tlpGeneralLUC, 0, 0);
            this.tlpGeneralUC.Controls.Add(this.chartGeneralUC, 1, 0);
            this.tlpGeneralUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneralUC.Location = new System.Drawing.Point(0, 0);
            this.tlpGeneralUC.Name = "tlpGeneralUC";
            this.tlpGeneralUC.RowCount = 1;
            this.tlpGeneralUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneralUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGeneralUC.Size = new System.Drawing.Size(1113, 664);
            this.tlpGeneralUC.TabIndex = 0;
            // 
            // tlpGeneralLUC
            // 
            this.tlpGeneralLUC.BackColor = System.Drawing.Color.White;
            this.tlpGeneralLUC.ColumnCount = 1;
            this.tlpGeneralLUC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneralLUC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGeneralLUC.Controls.Add(this.labelGeneralLBotUC, 0, 1);
            this.tlpGeneralLUC.Controls.Add(this.labelGeneralLTopUC, 0, 0);
            this.tlpGeneralLUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneralLUC.Location = new System.Drawing.Point(3, 3);
            this.tlpGeneralLUC.Name = "tlpGeneralLUC";
            this.tlpGeneralLUC.RowCount = 2;
            this.tlpGeneralLUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.55623F));
            this.tlpGeneralLUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.44377F));
            this.tlpGeneralLUC.Size = new System.Drawing.Size(386, 658);
            this.tlpGeneralLUC.TabIndex = 0;
            // 
            // labelGeneralLBotUC
            // 
            this.labelGeneralLBotUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGeneralLBotUC.AutoSize = true;
            this.labelGeneralLBotUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneralLBotUC.Location = new System.Drawing.Point(53, 387);
            this.labelGeneralLBotUC.Name = "labelGeneralLBotUC";
            this.labelGeneralLBotUC.Size = new System.Drawing.Size(279, 39);
            this.labelGeneralLBotUC.TabIndex = 2;
            this.labelGeneralLBotUC.Text = "Texto de prueba";
            // 
            // labelGeneralLTopUC
            // 
            this.labelGeneralLTopUC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGeneralLTopUC.AutoSize = true;
            this.labelGeneralLTopUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelGeneralLTopUC.Location = new System.Drawing.Point(80, 62);
            this.labelGeneralLTopUC.Name = "labelGeneralLTopUC";
            this.labelGeneralLTopUC.Size = new System.Drawing.Size(225, 31);
            this.labelGeneralLTopUC.TabIndex = 1;
            this.labelGeneralLTopUC.Text = "Texto de prueba";
            // 
            // chartGeneralUC
            // 
            this.chartGeneralUC.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "Año";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Title = "Ventas (€)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.chartGeneralUC.ChartAreas.Add(chartArea1);
            this.chartGeneralUC.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartGeneralUC.Legends.Add(legend1);
            this.chartGeneralUC.Location = new System.Drawing.Point(395, 3);
            this.chartGeneralUC.Name = "chartGeneralUC";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Ingresos";
            this.chartGeneralUC.Series.Add(series1);
            this.chartGeneralUC.Size = new System.Drawing.Size(715, 658);
            this.chartGeneralUC.TabIndex = 1;
            this.chartGeneralUC.Text = "chart1";
            // 
            // GeneralUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpGeneralUC);
            this.Name = "GeneralUC";
            this.Size = new System.Drawing.Size(1113, 664);
            this.tlpGeneralUC.ResumeLayout(false);
            this.tlpGeneralLUC.ResumeLayout(false);
            this.tlpGeneralLUC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralUC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGeneralUC;
        private System.Windows.Forms.TableLayoutPanel tlpGeneralLUC;
        private System.Windows.Forms.Label labelGeneralLBotUC;
        private System.Windows.Forms.Label labelGeneralLTopUC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneralUC;
    }
}
